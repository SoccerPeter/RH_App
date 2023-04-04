using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_App.Models
{
    public partial class Result
    {
        public string Group { get; set; }
        public string GroupInfo { get; set; }
        public string Image { get; set; }
        public string ShortInfo { get; set; }
        public string idArtist { get; set; }
        public string strLabel { get; set; }
        public string intFormedYear { get; set; }
        public string strStyle { get; set; }
    }

    public class ArtistInfo
    {
        public string type { get; set; }
        public string operation { get; set; }
        public bool success { get; set; }
        public Result result { get; set; }
    }


}
