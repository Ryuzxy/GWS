using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWS.Models
{
        public class Pasien
        {
            public int Id { get; set; }
            public string Nama { get; set; }
            public DateTime TanggalLahir { get; set; }
            public string Alamat { get; set; }
            public string JenisKelamin { get; set; }
            public string NoTelepon { get; set; }
        }
}
