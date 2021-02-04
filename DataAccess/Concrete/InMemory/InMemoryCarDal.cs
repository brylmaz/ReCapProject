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
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=200,ModelYear=1997,Description="Güzel araba"},
                new Car{Id=2,BrandId=1,ColorId=1,DailyPrice=400,ModelYear=1998,Description="Güzel araba1"},
                new Car{Id=3,BrandId=2,ColorId=3,DailyPrice=500,ModelYear=1999,Description="Güzel araba2"},
                new Car{Id=4,BrandId=2,ColorId=5,DailyPrice=600,ModelYear=2000,Description="Güzel araba3"},
                new Car{Id=5,BrandId=2,ColorId=6,DailyPrice=700,ModelYear=2000,Description="Güzel araba4"}
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            //Linq
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        

        public List<Car> GetById(int Id)
        {
            return _car.Where(c => c.Id == Id).ToList();
        }

      

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
