using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KisiDefteri
{
    public class Kisi
    {
        public string Ad { get; set; } = "";
        public string Soyad { get; set; } = "";

        [JsonIgnore]  // Bir satır altındakini json oluştururken ignore eder.
        public string TamAd => $"{Ad} {Soyad}";
    }
}
