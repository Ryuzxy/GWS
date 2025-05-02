using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWS.Models
{
    public class Resep
    {
        public int Id { get; set; }
        public int PendaftaranId { get; set; }
        public int ObatId { get; set; }
        public string Dosis { get; set; }
    }
}
