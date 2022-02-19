using AutoMapper;
using CursoArquitecturaNet.Core.Entities;
using CursoArquitecturaNet.WebApi.DTOs;

namespace CursoArquitecturaNet.WebApi.Mapper
{
    public class ProductMapperProfiles : Profile
    {
        public ProductMapperProfiles()
        {
            CreateMap<ProductDTO, Product>().ReverseMap();
        }
    }
}
