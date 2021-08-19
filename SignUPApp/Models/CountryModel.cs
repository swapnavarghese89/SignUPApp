using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUPApp.Models
{
    public class CountryModel
    {
        public string CountryId { get; set; }
        public string Country { get; set; }
       

    }
    //public class City
    //{
    //    public string CityId { get; set; }
    //    public string CityName { get; set; }
    //    public string CountryId { get; set; }
    //    public CountryModel Country { get; set; }

    //    public List<City> GetCityNames()
    //    {
    //        return new List<City>
    //        {
    //            new City{CityName="Kolkata",CityId= "1",CountryId="1"},
    //            new City{CityName="Delhi",CityId= "2",CountryId="1"},
    //            new City{CityName="NewYork",CityId= "3",CountryId="2"},
    //            new City{CityName="Washington",CityId= "4",CountryId="2"},
    //            new City{CityName="Tokyo",CityId= "5",CountryId="3"},
                
    //        };
    //    }
    //}
}
