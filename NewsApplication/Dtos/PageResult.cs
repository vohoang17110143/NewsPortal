using System;
using System.Collections.Generic;
using System.Text;

namespace NewsApplication.Dtos
{
    public class PageResult<T>
    {
       public List<T> Items { get; set; }
       public int TotalRecord { get; set; }
    }
}
