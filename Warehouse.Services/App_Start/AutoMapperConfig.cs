using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Warehouse.Common.Entities;
using Warehouse.Services.Models.Document;
using Warehouse.Services.Models.Product;

namespace Warehouse.Services.App_Start
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<DocumentRequest, DocumentItem>();
                cfg.CreateMap<DocumentItem, DocumentRequest>();
                cfg.CreateMap<ProductRequest, Product>();
                cfg.CreateMap<Product, ProductRequest>();

            });
        }
    }
}