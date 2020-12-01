using System;
using System.Collections.Generic;
using System.Text;

namespace MultilevelListViewXF.Model
{
    public class productClass: List<ProductSubClass>
    {
        public string groupName { get; set; }

        public productClass(string title)
        {
            groupName = title;
            
        }

        public static IList<productClass> All { private get; set; }
    }
}
