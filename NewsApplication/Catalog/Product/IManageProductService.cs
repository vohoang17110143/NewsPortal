﻿
using Microsoft.AspNetCore.Http;
using NewsViewModel.Catalog.Common;
using NewsViewModel.Catalog.Products;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewsApplication.Catalog.Product
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest  request);

        Task<int>Delete(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewCount(int productId);

     

        Task<List<ProductViewModel>> GetAll();

        Task<PageResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);

        Task<int> AddImages(int productId, List<IFormFile> files);

        Task<int> RemoveImages(int imageId);

        Task<int> UpdateImage(int imageId, string caption, bool isDefault);

        Task<List<ProductImageViewModel>> GetListImage(int productId);
    }
}
