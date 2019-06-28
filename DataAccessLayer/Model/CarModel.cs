using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace DataAccessLayer.Model
{

    public class CarModel
    {
        public int Id { get; set; }

        public string ModelName { get; set; }

        public DateTime ModelDate { get; set; }

        public MachineBodyType BodyType { get; set; }

        public decimal WarriantyRun { get; set; }

        public ICollection<Cars> Carss { get; set; }
        public CarModel()
        {
            Carss = new List<Cars>();
        }
    }
}
