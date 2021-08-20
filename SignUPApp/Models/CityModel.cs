using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUPApp.Models
{
    public class CityModel
    {
            public string CityId { get; set; }
            public string CityName { get; set; }
            public string CountryId { get; set; }
            public CountryModel Country { get; set; }

            public List<CityModel> GetCityNames()
            {
                return new List<CityModel>
            {
                new CityModel{CityName="Kolkata",CityId= "1",CountryId="1"},
                new CityModel{CityName="Delhi",CityId= "2",CountryId="1"},
                new CityModel{CityName="NewYork",CityId= "3",CountryId="2"},
                new CityModel{CityName="Washington",CityId= "4",CountryId="2"},
                new CityModel{CityName="Tokyo",CityId= "5",CountryId="3"},

            };
            }
        }
    }

