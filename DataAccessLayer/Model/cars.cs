using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Cars
    {
        [Key]
        public int Win { get; set; }

        public DateTime CarDate { get; set; }
        public string Color { get; set; }
        public int Model { get; set; }

        public sales sale { get; set; }

        public CarModel CarModel { get; set; }
    }
}

