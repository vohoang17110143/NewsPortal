using NewsApplication.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsApplication.Catalog.Product.Dtos.Manage
{
   public  class GetProductPagingRequest:PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryId { get; set; }
    }
}
