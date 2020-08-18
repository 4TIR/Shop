using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars 
        {
            get
            {
                return new List<Car>
                {
                    new Car {name = "Tesla",shortDesc = "",longDesc = "",
                    img ="/img/tesla.jpg",price = 45000,isFavourite = true, available = true,
                    Category = _categoryCars.AllCategories.First()
                    },
                    new Car {name = "Ford",shortDesc = "",longDesc = "",
                    img ="/img/ford.jpeg",price = 35000,isFavourite = true, available = true,
                    Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {name = "Tesla",shortDesc = "",longDesc = "",
                    img ="/img/tesla.jpg",price = 45000,isFavourite = true, available = true,
                    Category = _categoryCars.AllCategories.First()
                    },
                    new Car {name = "Mercedes",shortDesc = "",longDesc = "",
                    img ="/img/mercedes.jpeg",price = 48000,isFavourite = true, available = true,
                    Category = _categoryCars.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get ; set ; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
