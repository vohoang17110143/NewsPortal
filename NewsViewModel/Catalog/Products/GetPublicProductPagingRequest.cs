using NewsViewModel.Catalog.Products;
using NewsViewModel.Catalog.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsViewModel.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }

    }
}
