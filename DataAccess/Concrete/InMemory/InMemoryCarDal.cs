using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public string BrandId { get; private set; }

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
              new Car{  Id=1, Brandld="Ford", Colorld=17, ModelYear=2021, DailyPrice=100000, Description="Sahibinden satılık!"},
              new Car{  Id=2, Brandld="Ferrari", Colorld=15, ModelYear=2020, DailyPrice=500000, Description="Engin hocadan satılık!"},
              new Car{  Id=3, Brandld="Volvo", Colorld=17, ModelYear=2019, DailyPrice=250000, Description="Öğretmenden satılık!"},
              new Car{  Id=4, Brandld="BMW", Colorld=18, ModelYear=2018, DailyPrice=350000, Description="Mühendisten satılık!"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }


        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.Brandld = car.Brandld;
            carToUpdate.Colorld = car.Colorld;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetAll(int Id)
        {
            return _cars.Where(c=>c.Id == Id).ToList();
        }
        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Brandld == BrandId).ToList();
        }
    }
}
