using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreManagement
{
    public class ArtistViewModel
    {
        public int ArtistId { get; set; }
        public string ArtistCode { get; set; }
        public string ArtistName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public bool IsPermanent { get; set; }
        public int TotalExperience { get; set; }
        public string CatagoryTitle { get; set; }
        public string ImagePath { get; set; }
    }
}
