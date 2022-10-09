using MagicVilla.VillaWeb.Models.DTOs;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MagicVilla.VillaWeb.Models.VMs;

public sealed class VillaNumberDeleteVM
{
	public VillaNumberDeleteVM()
	{
        VillaNumber = new VillaNumberDTO();
	}

	public VillaNumberDTO VillaNumber { get; set; }
	
	[ValidateNever]
	public IEnumerable<SelectListItem> VillaList { get; set; }
}
