  
string again = "a";
  while(again == "a") {

            Console.Clear();
            Console.WriteLine("******************");
            Console.WriteLine("**** Obdélník ****");
            Console.WriteLine("****** Rose ******");
            Console.WriteLine("******************");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Zadejte šířku obrazce (kladné celé číslo): ");
            uint width;
            while(!uint.TryParse(Console.ReadLine(), out width)) {
                Console.Write("Nezadali jste kladné celé číslo. Zadejte šířku znovu: ");
            }

            Console.Write("Zadejte výšku obrazce (kladné celé číslo): ");
            uint height;
            while(!uint.TryParse(Console.ReadLine(), out height)) {
                Console.Write("Nezadali jste kladné celé číslo. Zadejte výšku znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("Šířka: {0}", width);
            Console.WriteLine("Výška: {0}", height);
            Console.WriteLine("========================================================");


            // for(int i = 1; i<=10; i++) {
            //     Console.WriteLine(i);
            // }

            // int j = 1;
            // while(j<=10) {
            //     Console.WriteLine(j);
            //     j++;
            // }

            for(int i=1; i <= height ;i++) {
                for(int j=1; j <= width  ;j++) {
                    Console.Write("* ");
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
                }
                Console.WriteLine();
            }       
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();    

        }
