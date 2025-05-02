using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWS.Models
{
    public class Pendaftaran
    {
        public int Id { get; set; }
        public int PasienId { get; set; }
        public int DokterId { get; set; }
        public DateTime Tanggal { get; set; }
        public string Keluhan { get; set; }
    }
}
