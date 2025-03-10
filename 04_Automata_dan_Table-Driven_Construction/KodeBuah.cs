using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3_2311104041
{

    public class KodeBuah
    {
        private static readonly Dictionary<string, string> kodeBuahMap = new Dictionary<string, string>()
    {
        {"Apel", "A00"},
        {"Aprikot", "B00"},
        {"Alpukat", "C00"},
        {"Pisang", "D00"},
        {"Paprika", "E00"},
        {"Blackberry", "F00"},
        {"Ceri", "H00"},
        {"Kelapa", "I00"},
        {"Jagung", "J00"},
        {"Kurma", "K00"},
        {"Durian", "L00"},
        {"Anggur", "M00"},
        {"Melon", "N00"},
        {"Semangka", "O00"}
    };

        public static string GetKodeBuah(string namaBuah)
        {
            return kodeBuahMap.TryGetValue(namaBuah, out string kode) ? kode : "Kode Tidak Ditemukan";
        }
    }
}