using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWS.Models
{
    public class Jadwal
    {
        public int Id { get; set; }
        public string Hari { get; set; }
        public string Jam { get; set; }
        public string Dokter { get; set; }
    }
}

