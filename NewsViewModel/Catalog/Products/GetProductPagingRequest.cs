using NewsViewModel.Catalog.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsViewModel.Catalog.Products
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryId { get; set; }
    }
}
