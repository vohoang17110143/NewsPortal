
using NewsViewModel.Catalog.Common;
using NewsViewModel.Catalog.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewsApplication.Catalog
{
    public interface IPublicProductService
    {
       Task< PageResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll();
    }
}
