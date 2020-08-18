using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void initial(AppDBContent content)
        {
            
           
          
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["electro"]
                    },
                    new Car
                    {
                        name = "Ford",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/ford.jpeg",
                        price = 35000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["classic"]
                    },
                    new Car
                    {
                        name = "Tesla",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["electro"]
                    },
                    new Car
                    {
                        name = "Mercedes",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/mercedes.jpeg",
                        price = 48000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["classic"]
                    }
                    );
            }
            content.SaveChanges();

        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string,Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                    new Category { categoryName = "electro", desc = "Sovremennii vid transporta" },
                    new Category { categoryName = "classic",desc = "Obichnie maszyny" }
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
                
            }
        }
    }
}
