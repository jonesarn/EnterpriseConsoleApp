using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enterprise.Repository
{
    public class EnterpriseRepository
    {
        List<EnterpriseCars> _carList = new List<EnterpriseCars>();
        //Create
        public void AddCarToList(EnterpriseCars enterpriseCars)
        {
            _carList.Add(enterpriseCars);
        }
        //Read
        public EnterpriseCars GetOneCar(int carId)
        {
            foreach (EnterpriseCars car in _carList)
            {
                if(car.CarId == carId)
                {
                    return car;
                }
            }
            return null;
        }
        //Read All
            public List<EnterpriseCars> GetAllCars()
            {
                return _carList;
            }
        //Update

        //Delete
        /*public void DeleteCar()
        {
            return _carList.Remove(enterpriseCars);
        }
        */
    }
}

