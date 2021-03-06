﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

using NLayerApp.DAL.Model;
using NLayerApp.DAL.Repositories;
using NLayerApp.DLL.Interfaces;
using NLayerApp.DLL.ViewModels;

namespace NLayerApp.DLL.Services
{
    public class ProductAppService : IProductAppService
    {
        private readonly IRepository<Product, int> _productRepository;
        private readonly IMapper _mapper;

        public ProductAppService(IRepository<Product, int> productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductViewModel>> GetProducts()
        {
            return _mapper.Map<IEnumerable<ProductViewModel>>(await _productRepository.Query());
        }
    }
}