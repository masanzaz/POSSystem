using AutoMapper;
using POSSystem.API.Dtos.Category;
using POSSystem.API.Dtos.Customer;
using POSSystem.API.Dtos.Order;
using POSSystem.API.Dtos.OrderDetail;
using POSSystem.API.Dtos.PaymentMethod;
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

            CreateMap<Customer, CustomerAddDto>().ReverseMap();
            CreateMap<Customer, CustomerEditDto>().ReverseMap();
            CreateMap<Customer, CustomerResultDto>().ReverseMap();

            CreateMap<PaymentMethod, PaymentAddDto>().ReverseMap();
            CreateMap<PaymentMethod, PaymentEditDto>().ReverseMap();
            CreateMap<PaymentMethod, PaymentResultDto>().ReverseMap();

            CreateMap<Order, OrderAddDto>().ReverseMap();
            CreateMap<Order, OrderEditDto>().ReverseMap();
            CreateMap<Order, OrderResultDto>().ReverseMap();

            CreateMap<OrderDetail, OrderDetailAddDto>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailEditDto>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailResultDto>().ReverseMap();
        }
    }
}
