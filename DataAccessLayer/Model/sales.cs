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
    public class sales
    {
        [Key]
        public int car { get; set; }
        public DateTime buy_date { get; set; }

        public int? ClientsId { get; set; }
        public clients Clients { get; set; }
        /*
        public Cars cars { get; set; }

        public clients ClientId { get; set; }
        */
    }

}
