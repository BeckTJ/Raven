﻿using AutoMapper;
using RavenDAL.DTO;
using RavenDAL.Models;

namespace RavenAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            //DAL
            CreateMap<Material, MaterialDTO>();
            CreateMap<MaterialVendor, MaterialVendorDTO>();
            CreateMap<VendorLot, VendorLotDTO>();
            CreateMap<RawMaterial, RawMaterialDTO>();
            CreateMap<SampleSubmit, SampleDTO>();
            CreateMap<CreateRawMaterialDTO, RawMaterial>();

            //BAL

        }
    }
}
