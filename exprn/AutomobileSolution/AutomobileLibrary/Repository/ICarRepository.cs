using AutomobileLibrary.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCar();
        Car GetCarByID(int carId);
        void UpdateCar(Car car);
        void DeleteCar(Car carId);
        void InsertCar(Car car);
    }
}
