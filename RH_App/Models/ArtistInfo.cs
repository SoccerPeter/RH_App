using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_App.Models
{
    public partial class Result
    {
        public string group { get; set; }
        public string groupInfo { get; set; }
        public string image { get; set; }
        public string shortInfo { get; set; }
    }

    public class ArtistInfo
    {
        public string type { get; set; }
        public string operation { get; set; }
        public bool success { get; set; }
        public Result result { get; set; }
    }


}
