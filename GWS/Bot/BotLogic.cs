using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWS.Bot
{
    public class BotLogic
    {
        public string GetResponse(string input, string role)
        {
            input = input.ToLower();

            if (role == "pasien")
            {
                if (input.Contains("jadwal"))
                    return "Jadwal dokter hari ini: ...";
                if (input.Contains("cara daftar"))
                    return "Silakan isi form pendaftaran di menu Pasien.";
            }
            else if (role == "admin")
            {
                if (input.Contains("jumlah pasien"))
                    return "Jumlah pasien hari ini: 12.";
                if (input.Contains("stok obat"))
                    return "Stok obat aman.";
            }

            return "Maaf, saya tidak mengerti pertanyaan Anda.";
        }
    }

}
