﻿using Shared.DTO;

namespace Service.Contracts
{
    public interface IMaterialVendorServices
    {
        Task<MaterialVendorDTO> GetMaterialVendorByMaterialNumber(int materialNumber);
        Task<IEnumerable<MaterialVendorWithRawMaterialDTO>> GetApprovedRawMaterial(int materialNumber);
        Task<IEnumerable<RequiredSampleDTO>> InputRawMaterial(CreateRawMaterialDTO material);
        MaterialVendorDTO GetMaterialVendor(int materialNumber);
    }
}
