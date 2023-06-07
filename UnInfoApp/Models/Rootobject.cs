using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnInfoApp.Models
{

    public class Rootobject
    {
        public string country { get; set; }
        public string alpha_two_code { get; set; }
        public string name { get; set; }
        public object stateprovince { get; set; }
        public string[] domains { get; set; }
        public string[] web_pages { get; set; }
    }

}
