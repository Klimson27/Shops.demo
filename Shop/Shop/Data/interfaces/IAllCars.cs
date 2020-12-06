using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public interface IAllCars
    {
        IEnumerable<Car> getFavCars { get; set; }
        IEnumerable<Car> Cars { get;  }
        Car getObjectCar(int carid);
    }
}
