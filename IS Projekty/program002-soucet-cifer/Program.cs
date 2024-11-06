string again = "a";
        while(again == "a") {

            Console.Clear();
            Console.WriteLine("*******************************");
            Console.WriteLine("**** Součet a součin cifer ****");
            Console.WriteLine("************ Rose *************");
            Console.WriteLine("*******************************");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Zadejte číslo (celé číslo): ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Nezadali jste celé číslo. Zadejte číslo (celé číslo): ");
            }
            
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("Číslo: {0}", number);
            Console.WriteLine("========================================================");
            
            int suma = 0;
            int multi = 1;
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
                multi = multi * digit;
            }

            Console.WriteLine("Aktuální zbytek = {0}", number);
            suma = suma + number;
            multi = multi * number;

            Console.WriteLine("\n\nSoučet cifer čísla {0} je {1}", numberBackup, suma);
            Console.WriteLine("\n\nSoučin cifer čísla {0} je {1}", numberBackup, multi);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();    

        }