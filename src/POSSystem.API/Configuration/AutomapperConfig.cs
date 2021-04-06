using AutoMapper;
using POSSystem.API.Dtos.Category;
using POSSystem.API.Dtos.Product;
using POSSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSSystem.API.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Category, CategoryAddDto>().ReverseMap();
            CreateMap<Category, CategoryEditDto>().ReverseMap();
            CreateMap<Category, CategoryResultDto>().ReverseMap();
            CreateMap<Product, ProductAddDto>().ReverseMap();
            CreateMap<Product, ProductEditDto>().ReverseMap();
            CreateMap<Product, ProductResultDto>().ReverseMap();
        }
    }
}
