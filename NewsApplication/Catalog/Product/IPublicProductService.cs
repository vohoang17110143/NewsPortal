
using NewsViewModel.Catalog.Common;
using NewsViewModel.Catalog.Products.Dtos;
using NewsViewModel.Catalog.Products.Dtos.Public;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewsApplication.Catalog
{
    public interface IPublicProductService
    {
       Task< PageResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
