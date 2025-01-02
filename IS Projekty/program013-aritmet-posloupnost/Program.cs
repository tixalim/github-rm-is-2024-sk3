   
string again = "a";
        while(again == "a") {   

            Console.WriteLine("*****************************");
            Console.WriteLine("***Aritmetická posloupnost***");
            Console.WriteLine("*****************************");
            Console.WriteLine("********* Rose **************");
            Console.WriteLine("*****************************");

            
            Console.Write("Zadejte počet čísel: ");
            int pocetCisel;
            while (!int.TryParse(Console.ReadLine(), out pocetCisel) || pocetCisel <= 0)
            {
                Console.Write("Špatný vstup. Zadejte počet čísel (kladné celé číslo): ");
            }

            Console.Write("Zadejte diferenci: ");
            int diference;
            while (!int.TryParse(Console.ReadLine(), out diference))
            {
                Console.Write("Špatný vstup. Zadejte diferenci (celé číslo): ");
            }

            Console.Write("Zadejte první prvek posloupnosti: ");
            int prvniPrvek;
            while (!int.TryParse(Console.ReadLine(), out prvniPrvek))
            {
                Console.Write("Špatný vstup. Zadejte první prvek posloupnosti (celé číslo): ");
            }

            Console.WriteLine("\nVýsledná aritmetická posloupnost:");
            int soucet = 0;
            for (int i = 0; i < pocetCisel; i++)
            {
                int clen = prvniPrvek + i * diference;
                Console.Write(clen);

                if (i < pocetCisel - 1)
                    Console.Write("; "); 
                else
                    Console.WriteLine(";"); 

                soucet += clen; 
            }

            Console.WriteLine($"\nSoučet zobrazených hodnot: {soucet}");
        
        Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();
    }