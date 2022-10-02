using AutoMapper;
using MagicVilla.VillaWeb.Models;
using MagicVilla.VillaWeb.Models.DTOs;
using MagicVilla.VillaWeb.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MagicVilla.VillaWeb.Controllers;

public sealed class VillaNumberController : Controller
{
    private readonly IVillaNumberService _villaNumberService;
    private readonly IMapper _mapper;

    public VillaNumberController(IVillaNumberService villaNumberService, IMapper mapper)
    {
        _villaNumberService = villaNumberService;
        _mapper = mapper;
    }
    public async Task<IActionResult> IndexVillaNumber()
    {
        List<VillaNumberDTO> list = new();

        var response = await _villaNumberService.GetAllAsync<APIResponse>();

        if (response != null && response.IsSuccess)
        {
            list = JsonConvert.DeserializeObject<List<VillaNumberDTO>>(Convert.ToString(response.Result));
        }
        return View(list);
    }

    [HttpGet]
    public IActionResult CreateVillaNumber()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateVillaNumber(VillaNumberCreateDTO model)
    {

        if (ModelState.IsValid)
        {
            var response = await _villaNumberService.CreateAsync<APIResponse>(model);
            if (response != null && response.IsSuccess)
            {
                return RedirectToAction(nameof(IndexVillaNumber));
            }
        }


        return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> UpdateVillaNumber(int villaId)
    {
        var response = await _villaNumberService.GetAsync<APIResponse>(villaId);
        if (response != null && response.IsSuccess)
        {
            VillaDTO model = JsonConvert.DeserializeObject<VillaDTO>(Convert.ToString(response.Result));
            return View(_mapper.Map<VillaNumberUpdateDTO>(model));
        }

        return NotFound();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> UpdateVilla(VillaNumberUpdateDTO model)
    {
        if (ModelState.IsValid)
        {
            var response = await _villaNumberService.UpdateAsync<APIResponse>(model);
            if (response != null && response.IsSuccess)
            {
                return RedirectToAction(nameof(IndexVillaNumber));
            }
        }

        return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> DeleteVilla(int villaId)
    {
        var response = await _villaNumberService.GetAsync<APIResponse>(villaId);
        if (response != null && response.IsSuccess)
        {
            VillaDTO model = JsonConvert.DeserializeObject<VillaDTO>(Convert.ToString(response.Result));
            return View(model);
        }

        return NotFound();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteVilla(VillaDTO model)
    {
        var response = await _villaNumberService.DeleteAsync<APIResponse>(model.Id);
        if (response != null && response.IsSuccess)
        {
            return RedirectToAction(nameof(IndexVillaNumber));
        }

        return View(model);
    }
}
