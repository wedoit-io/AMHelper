using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace AMHelper.WS
{
    public class ws_meta
    {
        public decimal limit { get; set; }
        public decimal maxID { get; set; }
        public decimal offset { get; set; }
        public decimal total_count { get; set; }
    }
}
