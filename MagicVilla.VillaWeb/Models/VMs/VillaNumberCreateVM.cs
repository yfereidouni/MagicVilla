using MagicVilla.VillaWeb.Models.DTOs;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MagicVilla.VillaWeb.Models.VMs;

public sealed class VillaNumberCreateVM
{
	public VillaNumberCreateVM()
	{
        VillaNumber = new VillaNumberCreateDTO();
	}

	public VillaNumberCreateDTO VillaNumber { get; set; }
	
	[ValidateNever]
	public IEnumerable<SelectListItem> VillaList { get; set; }
}
