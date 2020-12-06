using Shop.Data.interfaces;
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
                    new Car
                    {
                        name = "Tesla",
                        shortDesc = "Швидкий автомобіль",
                        longDesc = "Швидкий,гарний і дуже тихий автомобіль компанії Tesla",
                        img = "https://delo.ua/files/news/images/3644/29/picture2_tesla-otkljuchila_364429_p0.jpg",
                        price = 11000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий і комфортний",
                        longDesc = "Зручний автомобіль для міста",
                        img = "https://fordcms.blob.core.windows.net/media/Ukraine/_Profiles/24613dd5/6521fe91/C_Users_Design_AppData_Local_Packages_Microsoft.SkypeApp_kzf8qxf38zg5c_LocalState_cd5dbb5f-7871-425f-9c4b-9ae3d06b2b3c.jpg?v=636728617130000000",
                        price = 65000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Гарний і швидкий",
                        longDesc = "Зручний автомобіль для міста",
                        img = "https://i.infocar.ua/i/6/136856/650x.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Mercedes C class",
                        shortDesc = "Затишний і великий",
                        longDesc = "Зручний автомобіль для міста",
                        img = "https://cdn.riastatic.com/photosnewr/auto/newauto_photos/mercedes-benz-c-class__752977-620x415x70.jpg",
                        price = 40000,
                        isFavourite = false,
                        available = false,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Тихий і економний",
                        longDesc = "Зручний автомобіль для міста",
                        img = "https://e-move.com.ua/wp-content/uploads/2016/03/NissanLeaf_2011-12.png",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    }
                };


            }
        }
        public IEnumerable<Car> getFavCars { get; set; }


        public Car getObjectCar(int carid)
                {
                    throw new NotImplementedException();
                }
            }
        }
