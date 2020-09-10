using NewsViewModel.Catalog.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsViewModel.Catalog.Products.Dtos.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryId { get; set; }
    }
}
