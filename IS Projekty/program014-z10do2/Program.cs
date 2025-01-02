string again = "a";
        while(again == "a") {

            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("**** Převod z 10 do 2 soustavy ****");
            Console.WriteLine("******* Rose ********");
            Console.WriteLine("****************************");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Zadejte číslo v desítkové soustavě (přirozené číslo): ");
            uint cislo;
            while(!uint.TryParse(Console.ReadLine(), out cislo)) {
                Console.Write("Špatný vstup. Zadejte číslo v desítkové soustavě (přirozené číslo):");
            }
            
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("Desítkové číslo: {0}", cislo);
            Console.WriteLine("========================================================");


            uint[] myArray = new uint[32];
            uint zaloha = cislo;
            uint zbytek;

            uint i=0;
            while(cislo > 0) {
                zbytek = cislo % 2;
                cislo = (cislo - zbytek)/2;
                myArray[i] = zbytek;

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Celá část = {0}, zbytek = {1}", cislo, zbytek);
                
                i++;
            }

            Console.WriteLine("\n\nPoslední použitá buňka pole: {0}", i-1);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n Číslo {0} převedené do binární soustavy: ", zaloha);
            for (int j = (int)(i - 1); j >= 0; j--) {
            Console.Write("{0}", myArray[j]);
            }
            
            Console.ForegroundColor = ConsoleColor.White;    

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();    

        }