using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteniMartinPrusa
{
    internal class Hlavicka
    {
        string hlava =
            "---------------------------------- -\n" +
            "        Evidence Pojištěných       \n" +
            "-----------------------------------\n" +
            "\n" +
            "vyberte si akci:\n" +
            "1.-- přidej noveho pojištěného\n" +
            "2.-- vypiš všechny pojištěné\n" +
            "3.-- vyhledej pojištěného\n" +
            "4.-- vyčisti obrazovku\n" +
            "5.-- ukončit program\n";

        public string VolejHlavu() { return hlava; }
            
            
    }
}
