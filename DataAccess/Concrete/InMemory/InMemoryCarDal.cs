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
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=250000,ModelYear=2010,Description="2010 Model Honda Civic White"},
                new Car{Id=2,BrandId=1,ColorId=2,DailyPrice=350000,ModelYear=2014,Description="2014 Model Honda Cobra Red"},
                new Car{Id=3,BrandId=2,ColorId=5,DailyPrice=500000,ModelYear=2023,Description="2023 Model Mercedes Benz Black"},
                new Car{Id=4,BrandId=3,ColorId=3,DailyPrice=150000,ModelYear=2002,Description="2002 Model Tofaş Street Blue"},
                new Car{Id=5,BrandId=4,ColorId=1,DailyPrice=923000,ModelYear=2022,Description="2022 Model Ferrari Super"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c=>c.Id==id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
