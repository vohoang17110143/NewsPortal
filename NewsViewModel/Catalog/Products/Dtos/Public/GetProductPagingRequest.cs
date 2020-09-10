using NewsViewModel.Catalog.Products.Dtos.Manage;
using NewsViewModel.Catalog.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsViewModel.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }

    }
}
