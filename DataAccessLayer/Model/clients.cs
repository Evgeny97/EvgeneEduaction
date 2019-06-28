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
    public class clients
    {
        public string Phone { get; set; }
        public string fio { get; set; }
        public DateTime dob { get; set; }
        public int id { get; set; }


        public ICollection<sales> sale { get; set; }
        public clients()
        {
            sale = new List<sales>();
        }
    }
}