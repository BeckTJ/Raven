using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DTO;

namespace Presentation.Controllers;

[Route("RavenAPI/MaterialVendor")]
[ApiController]

public class MaterialVendorController : ControllerBase
{
    private readonly IServiceManager _service;

    public MaterialVendorController( IServiceManager repo)
    {
        _service = repo;
    }

    [HttpGet("{materialNumber:int}")]
    public IActionResult GetMaterialVendor(int materialNumber)
    {
            var materialVendor = _service.MaterialVendorServices.GetMaterialVendor(materialNumber);

            return Ok(materialVendor);
    }

    public void GetApprovedRawMaterial(int materialNumber) { }
    public void GetExpiredRawMaterial(int materialNumber) { }
    public void GetRawMaterialNeedingSample(int parentMaterialNumber) { }
    public void InputRawMaterial(CreateRawMaterialDTO material) { }

}