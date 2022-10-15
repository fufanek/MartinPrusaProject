// See https://aka.ms/new-console-template for more information

using EvidencePojisteniMartinPrusa;

Hlavicka hlavicka = new Hlavicka();

Console.WriteLine(hlavicka.VolejHlavu());

List<Pojistenci> pojistenci = new List<Pojistenci>();
pojistenci.AddRange(new List<Pojistenci>
{
    new Pojistenci ("Honza" , "Veliký"      , 24, 123456789),
    new Pojistenci ("Andrej", "Fobiš"       , 45, 234567891),
    new Pojistenci ("Honza" , "Malý"        , 14, 345678912),
    new Pojistenci ("Lorem" , "Ipsum"       , 24, 456789123),
    new Pojistenci ("Dolor" , "Sit"         , 54, 567891234),
    new Pojistenci ("Amet"  , "Conect"      , 41, 678912345),
});


void VypisSeznam()
{
    foreach (Pojistenci pojistenci_zobraz in pojistenci)
    {
        Console.WriteLine(pojistenci_zobraz);
    }
    
};


void PridejDoSeznamu()
{

    Console.WriteLine("Zadejte Jméno:");
    string jmeno;
    do
    {
        jmeno = Console.ReadLine();
        if (jmeno.Length < 3)                                           
            Console.WriteLine("Jméno musí obsahovat aspoň 3 znaky:");  
    }
    while (jmeno.Length < 3);


    Console.WriteLine("Zadejte příjmení:");
    string prijmeni;
    do
    {
        prijmeni = Console.ReadLine();
        if (prijmeni.Length < 3)                                        
            Console.WriteLine("Příjmení musí obsahovat aspoň 3 znaky:");
    }
    while (prijmeni.Length < 3);

    Console.WriteLine("Zadejte věk:");
    int vek;
    while (!int.TryParse(Console.ReadLine(), out vek))                    
        Console.WriteLine("Neplatný znak, zadejte prosím znovu:");      
    

    Console.WriteLine("Zadejte telefonní číslo:");
    int telefon;
    while (!int.TryParse(Console.ReadLine(), out telefon))             
        Console.WriteLine("Neplatný znak, zadejte prosím znovu:");   

    pojistenci.Add(new Pojistenci(jmeno, prijmeni, vek, telefon));
}


void VyhledavaniPojisteneho()
{
    Console.WriteLine("\nZadejte jméno pojištěného:");
    string JmenoHledaneho;
    do
    {
        JmenoHledaneho = Console.ReadLine();
        if (JmenoHledaneho.Length < 3)                                        // 
            Console.WriteLine("Jméno musí obsahovat aspoň 3 znaky:");         // osetreni
    }
    while (JmenoHledaneho.Length < 3);

    Console.WriteLine("Zadejte příjmení:");
    string PrijmeniHledaneho;
    do
    {
        PrijmeniHledaneho = Console.ReadLine();
        if (PrijmeniHledaneho.Length < 3)                                        // 
            Console.WriteLine("Příjmení musí obsahovat aspoň 3 znaky:");         // osetreni
    }
    while (PrijmeniHledaneho.Length < 3);

    Console.WriteLine();
    foreach (Pojistenci HledaniPojistencu in pojistenci)
    {
        if (HledaniPojistencu.jmeno == JmenoHledaneho && HledaniPojistencu.prijmeni == PrijmeniHledaneho)
        {
            Console.WriteLine(HledaniPojistencu);
        }
    }
}



bool pokracovat = true;
do
{
    int volba;
    while(!int.TryParse(Console.ReadLine(), out volba))             //
        Console.WriteLine("Neplatný znak, zadejte prosím znovu:");  //osetreni vstupu


    if (volba < 6 && volba>0)
    {
        switch (volba)
        {
            case 1:
                PridejDoSeznamu();
                Console.WriteLine("\nPojištěnec úspěšne přidán, vyberte další akci...");
                //Console.ReadKey();
                break;
            case 2:
                VypisSeznam();
                Console.WriteLine("\nVypsání proběhlo úspěšně, vyberte další akci...");
                //Console.ReadKey();
                break;
            case 3:
                VyhledavaniPojisteneho();
                Console.WriteLine("\nVyhledání proběhlo úspěšně, vyberte další akci...");
                //Console.ReadKey();
                break;
            case 5:
                pokracovat = false;
                Console.WriteLine("\nDěkujeme za použití našeho programu. \n\nStiskni náhodné tlačítko");
                Console.ReadKey();
                break;
            case 4:
                Console.Clear();
                Console.WriteLine(hlavicka.VolejHlavu());
                //Console.ReadKey();
                break;
        }
    }
    else
        Console.WriteLine("Neplatná volba");

}
while (pokracovat == true);
