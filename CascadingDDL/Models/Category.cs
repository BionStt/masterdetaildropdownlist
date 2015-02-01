using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadingDDL.Models
{
    public class Category
    {
        public string ManCode { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public static IQueryable<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category {
                    ManCode = "AC",
                    CategoryID = 1,
                    CategoryName = "Aspire R"
                },
                new Category {
                    ManCode = "AC",
                    CategoryID = 2,
                    CategoryName = "Aspire V3"
                },
                new Category {
                    ManCode = "AC",
                    CategoryID = 3,
                    CategoryName = "Aspire E"
                },
                new Category {
                    ManCode = "AP",
                    CategoryID = 4,
                    CategoryName = "MacBook Air"
                },
                new Category {
                    ManCode = "AP",
                    CategoryID = 5,
                    CategoryName = "MacBook Pro"
                },
                new Category {
                    ManCode = "AP",
                    CategoryID = 6,
                    CategoryName = "MacBook Retina"
                },
                new Category {
                    ManCode = "DE",
                    CategoryID = 7,
                    CategoryName = "XPS Family"
                },
                new Category {
                    ManCode = "DE",
                    CategoryID = 8,
                    CategoryName = "Inspiron Family"
                },
                new Category {
                    ManCode = "SN",
                    CategoryID = 9,
                    CategoryName = "VAIO Duo Ultrabooks"
                },
                new Category {
                    ManCode = "SN",
                    CategoryID = 10,
                    CategoryName = "VAIO Pro Ultrabooks"
                },
                new Category {
                    ManCode = "SN",
                    CategoryID = 11,
                    CategoryName = "VAIO Fit laptops"
                },
            }.AsQueryable();
        }
    }
}