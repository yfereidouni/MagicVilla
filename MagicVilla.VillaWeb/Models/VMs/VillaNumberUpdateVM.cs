using MagicVilla.VillaWeb.Models.DTOs;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MagicVilla.VillaWeb.Models.VMs;

public class VillaNumberUpdateVM
{
	public VillaNumberUpdateVM()
	{
        VillaNumber = new VillaNumberUpdateDTO();
	}

	public VillaNumberUpdateDTO VillaNumber { get; set; }
	
	[ValidateNever]
	public IEnumerable<SelectListItem> VillaList { get; set; }
}
