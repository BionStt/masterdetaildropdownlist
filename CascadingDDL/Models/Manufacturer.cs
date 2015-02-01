using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadingDDL.Models
{
    public class Manufacturer
    {
        public string ManCode { get; set; }
        public string ManName { get; set; }

        public static IQueryable<Manufacturer> GetManufacturers()
        {
            return new List<Manufacturer>
            {
                new Manufacturer {
                    ManCode = "AC",
                    ManName = "ACER"
                },
                new Manufacturer {
                    ManCode = "AP",
                    ManName = "APPLE"
                },
                new Manufacturer {
                    ManCode = "DE",
                    ManName = "DELL"
                },
                new Manufacturer {
                    ManCode = "SN",
                    ManName = "SONY"
                }
            }.AsQueryable();
        }
    }
}