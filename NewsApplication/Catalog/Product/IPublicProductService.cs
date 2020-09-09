using NewsApplication.Catalog.Product.Dtos;
using NewsApplication.Catalog.Product.Dtos.Public;
using NewsApplication.Dtos;
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
