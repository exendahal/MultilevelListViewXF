using System;
using System.Collections.Generic;
using System.Text;

namespace MultilevelListViewXF.Model
{
    public class ProductSubClass: List<productModel>
    {
        public string subClassName { get; set; }

        public ProductSubClass(string title)
        {
            subClassName = title;

        }

        public static IList<ProductSubClass> All { private get; set; }
    }
}
