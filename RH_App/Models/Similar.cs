using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_App.Models
{
    public partial class Result
    {
        public string name { get; set; }
        public string pic { get; set; }
        public string infoUrl { get; set; }
        public string info { get; set; }
    }

    public class Similar
    {
        public string type { get; set; }
        public string operation { get; set; }
        public bool success { get; set; }
        public List<Result> result { get; set; }
    }


}
