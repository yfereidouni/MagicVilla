﻿using MagicVilla.VillaWeb.Models;
using MagicVilla.VillaWeb.Models.DTOs;
using MagicVilla.VillaWeb.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla.VillaWeb.Controllers;

public class AuthController : Controller
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpGet]
    public IActionResult Login()
    {
        LoginRequestDTO obj = new();
        return View(obj);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Login(LoginRequestDTO obj)
    {
        return View(obj);
    }


    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(RegistrationRequestDTO obj)
    {
        APIResponse result= await _authService.RegisterAsync<APIResponse>(obj);
        if (result!=null && result.IsSuccess)
        {
            return RedirectToAction("Login");
        }
        return View();
    }

    public async Task<IActionResult> Logout()
    {
        return View();
    }

    public IActionResult AccessDenied()
    {
        return View();
    }


}
