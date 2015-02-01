using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadingDDL.Models
{
    public class Laptop
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public static IQueryable<Laptop> GetProducts() {
            return new List<Laptop>
            {
                new Laptop {
                    Category = "Aspire R",
                    Name = "R7-571-6858",
                    Price = 999m
                },
                new Laptop {
                    Category = "Aspire V3",
                    Name = "V3-772G-9460",
                    Price = 1299m
                },
                new Laptop {
                    Category = "Aspire V3",
                    Name = "V3-571G-9683",
                    Price = 849.99m
                },
                new Laptop {
                    Category = "Aspire E",
                    Name = "V3-772G-9653",
                    Price = 1992m
                },
                new Laptop {
                    Category = "MacBook Air",
                    Name = "11-inch MakBook Air",
                    Price = 999m
                },
                new Laptop {
                    Category = "MacBook Air",
                    Name = "13-inch MakBook Air",
                    Price = 1599m
                },
                new Laptop {
                    Category = "MacBook Pro",
                    Name = "11-inch MakBook Pro",
                    Price = 999m
                },
                new Laptop {
                    Category = "MacBook Pro",
                    Name = "13-inch MakBook Pro",
                    Price = 1099m
                },
                new Laptop {
                    Category = "MacBook Retina",
                    Name = "11-inch MakBook Retina",
                    Price = 2009m
                },
                new Laptop {
                    Category = "MacBook Retina",
                    Name = "13-inch MakBook Retina",
                    Price = 2100m
                },
                new Laptop {
                    Category = "XPS Family",
                    Name = "Ultrabook XPS 13",
                    Price = 1239m
                },
                new Laptop {
                    Category = "XPS Family",
                    Name = "XPS 14 Laptop Ultrabook",
                    Price = 1300m
                },
                new Laptop {
                    Category = "Inspiron Family",
                    Name = "Ultrabook Inspiron 13",
                    Price = 1239m
                },
                new Laptop {
                    Category = "Inspiron Family",
                    Name = "Inspiron 14 Laptop Ultrabook",
                    Price = 1300m
                },
                new Laptop {
                    Category = "XPS Family",
                    Name = "Ultrabook XPS 13",
                    Price = 1239m
                },
                new Laptop {
                    Category = "XPS Family",
                    Name = "XPS 14 Laptop Ultrabook",
                    Price = 1300m
                },
                new Laptop {
                    Category = "Inspiron Family",
                    Name = "Ultrabook Inspiron 13",
                    Price = 1239m
                },
                new Laptop {
                    Category = "Inspiron Family",
                    Name = "Inspiron 14 Laptop Ultrabook",
                    Price = 1300m
                },
                new Laptop {
                    Category = "VAIO Duo Ultrabooks",
                    Name = "Ultrabook XPS 13",
                    Price = 1239m
                },
                new Laptop {
                    Category = "VAIO Duo Ultrabooks",
                    Name = "Duo 11 Ultrabook",
                    Price = 1300m
                },
                new Laptop {
                    Category = "VAIO Pro Ultrabooks",
                    Name = "Duo 13 Ultrabook ",
                    Price = 1939m
                },
                new Laptop {
                    Category = "VAIO Pro Ultrabooks",
                    Name = "PRO 11 Ultrabook",
                    Price = 1332m
                },
                new Laptop {
                    Category = "VAIO Fit laptops",
                    Name = "Fit 14",
                    Price = 1334m
                },
                new Laptop {
                    Category = "VAIO Fit laptops",
                    Name = "Fit E15",
                    Price = 1340m
                },

            }.AsQueryable();
        }
    }
}