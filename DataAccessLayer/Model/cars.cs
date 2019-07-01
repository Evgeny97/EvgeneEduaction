using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
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
        public int? ModelId { get; set; }
        public CarModel Model { get; set; }
        static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {
                Cars p1 = new Cars { Color = "dssd" };
                Cars p2 = new Cars { Win = 2112, Color = "sd" };
                db.Carss.Add(p1);
                db.Carss.Add(p2);
                var carss = db.Carss.ToList();
                foreach (var p in carss)
                Console.WriteLine("{0}", p.Color);
            }

        }
    }
}

