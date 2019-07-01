using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer.Model
{
    public class CarModel
    {

        public int Id { get; set; }

        public string ModelName { get; set; }

        public DateTime ModelDate { get; set; }

        public MachineBodyType BodyType { get; set; }

        public decimal WarriantyRun { get; set; }


        public ICollection<Cars> carss { get; set; }
        public CarModel()
        {
            carss = new List<Cars>();
        }

        static void Main()
        {
            //добавление
            using (UserContext db = new UserContext())
            {
                CarModel p1 = new CarModel { ModelName = "Avto" };
                db.CarModels.Add(p1);
                var carModels = db.CarModels.ToList();
                foreach (var p in carModels)
                Console.WriteLine("{0}", p.ModelName);
            }

            //удаление
        //    using (UserContext db = new UserContext())
       //     {
       //        CarModel p1 = db.CarModels.FirstOrDefault();
        //        if(p1 != null)
       //         {
       //             db.CarModels.Remove(p1);
       //             db.SaveChanges();
        //        }
        //    }
            
            //редактирование
        //    using (UserContext db = new UserContext())
       //    {
        //        CarModel p1 = db.CarModels.FirstOrDefault();
        //        p1.ModelName = "fdvd";
         //       db.SaveChanges();
         //   }
        }
    }
}
