using MagicVilla.VillaAPI;
using MagicVilla.VillaAPI.Data;
using MagicVilla.VillaAPI.Logging;
using MagicVilla.VillaAPI.Repository;
using MagicVilla.VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;
using System;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IVillaRepository, VillaRepository>();
builder.Services.AddScoped<IVillaNumberRepository, VillaNumberRepository>();
builder.Services.AddScoped<ILocalUserRepository, LocalUserRepository>();

// Adding API Versioning
builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.ReportApiVersions = true;
});
builder.Services.AddVersionedApiExplorer(options =>
{
    options.GroupNameFormat = "'v'VVV";
    options.SubstituteApiVersionInUrl = true;
});
// EF Configuration -------------------------------------------------------------------------------
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));
//-------------------------------------------------------------------------------------------------

// AutoMapper Configuration -----------------------------------------------------------------------
builder.Services.AddAutoMapper(typeof(MappingConfig));
//-------------------------------------------------------------------------------------------------

// Serilog Config ---------------------------------------------------------------------------------
Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
    .WriteTo.File("Logs/VillaLogs.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();
builder.Host.UseSerilog();
//-------------------------------------------------------------------------------------------------

// Cutstom Logger configuration -------------------------------------------------------------------
//builder.Services.AddSingleton<ILogging, Logging>();
builder.Services.AddSingleton<ILogging, LoggingV2>();
//-------------------------------------------------------------------------------------------------

// Headers configuration for accepting "Application/XML" content ----------------------------------
builder.Services.AddControllers(options =>
{
    //options.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();
//-------------------------------------------------------------------------------------------------

//Setting Authentication and challenging schema ---------------------------------------------------
var key = builder.Configuration.GetValue<string>("ApiSettings:Secret");
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(x =>
    {
        x.RequireHttpsMetadata = false;
        x.SaveToken = true;
        x.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });
//-------------------------------------------------------------------------------------------------
builder.Services.AddEndpointsApiExplorer();

//------------------------------------------------------------------------------------------------
//Add JWT Token Pop-up ----------------------------------------------------------------------------
builder.Services.AddSwaggerGen(options =>
{
    //Top-Level Lock Button
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n" +
        "Enter 'Bearer' [space] and then your token in the input below. \r\n\r\n" +
        "Example: \"Bearer 12345abcdef\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Scheme = "Bearer"
    });
    //Action Methods Lock Button
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header
            },
            new List<string>()
        }
    });

    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Magic Villa",
        Description = "API to manage Villa",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Mr. Yasser Fereidouni",
            Url = new Uri("https://github.com/yfereidouni")
        },
        License = new OpenApiLicense
        {
            Name = "Free License",
            Url = new Uri("https://github.com/yfereidouni/yfereidouni")
        }
    });
});
//-------------------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------
var app = builder.Build();

//Database Auto-Migration -------------------------------------------------------------------------
//using (var scope = app.Services.CreateScope())
//{
//    var services = scope.ServiceProvider;
//    var context = services.GetRequiredService<ApplicationDbContext>();
//    context.Database.Migrate();
//}
//SeedDatabase ------------------------------------------------------------------------------------
//await AppDBInitializer.SeedingMasterDataAsync(app);
//await AppDBInitializer.SeedingUsersAndRolesAsync(app);
//-------------------------------------------------------------------------------------------------


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Magic_VillaV1");
    });
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
