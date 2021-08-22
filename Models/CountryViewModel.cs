using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_EXPart1.Models
{
    public class CountryViewModel
    {
        public CountryViewModel()
        {
            countryList = new List<tblCountry>()
            {
                new tblCountry{countryID = 1, countryName="United States", greeting="Hello"},
                new tblCountry{countryID = 2, countryName="Viet Nam", greeting="Xin Chao"},
                new tblCountry{countryID = 3, countryName="Mexico", greeting="Holla"}
            };
        }

        public int countryID { get; set; }
        public List<tblCountry> countryList { get; set; }
    }
}
