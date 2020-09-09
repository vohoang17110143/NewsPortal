using NewsApplication.Catalog.Product.Dtos.Manage;
using NewsApplication.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsApplication.Catalog.Product.Dtos.Public
{
   public  class GetProductPagingRequest: PagingRequestBase
    {
       public int? CategoryId { get; set; }
    
    }
}
