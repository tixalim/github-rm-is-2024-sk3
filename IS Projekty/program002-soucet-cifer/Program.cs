string again = "a";    
    
    while(again == "a") {

                Console.Clear();
                Console.WriteLine("****************************");
                Console.WriteLine("**** Výpis číselné řady ****");
                Console.WriteLine("******* Tomáš Žižka ********");
                Console.WriteLine("****************************");
                Console.WriteLine("*******************************");
                Console.WriteLine("**** Součet a součin cifer ****");
                Console.WriteLine("******** Tomáš Žižka **********");
                Console.WriteLine("*******************************");
                Console.WriteLine();
                Console.WriteLine();

    
                Console.WriteLine("Číslo: {0}", number);
                Console.WriteLine("========================================================");

                int suma = 0;
                int numberBackup = number;
                int digit;
                if(number < 0) {
                    number = -number;
                }

            
                while(number >= 10) {
                    digit = number % 10;
                    number = (number - digit)/10;
                    Console.WriteLine("Aktuální zbytek = {0}", digit);   
                    suma = suma + digit;
                }
                Console.WriteLine("Aktuální zbytek = {0}", number);
                suma = suma + number;
                Console.WriteLine("\n\nSoučet cifet čísla {0} je {1}", numberBackup, suma);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");

    }
