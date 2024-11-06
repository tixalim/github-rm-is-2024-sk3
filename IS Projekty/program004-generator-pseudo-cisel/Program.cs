﻿string again = "a";
        while(again == "a") {

            Console.Clear();
            Console.WriteLine("*****************************************");
            Console.WriteLine("**** Generátor pseudonáhod čísel ****");
            Console.WriteLine("****************** Rose *****************");
            Console.WriteLine("*****************************************");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu (celé číslo): ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu (celé číslo): ");
            }
           
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("========================================================\n\n");
            
            //deklarace pole o velikosti n prvku
            int[] myArray = new int[n];

            //priprava pro generator
            Random randomNumber = new Random();

            int kladna = 0;
            int zaporna = 0;
            int nuly = 0;    
            int suda = 0;
            int licha = 0;

            for(int i=0; i < n; i++){
                myArray [i] = randomNumber.Next(dm, hm);
                Console.Write("{0}; ", myArray[i]);

                /*if(myArray[i] > 0)
                    kladna++;
                if(myArray[i] < 0)
                    zaporna++;
                if(myArray[i] == 0)
                    nuly++;*/

                if(myArray[i] > 0)
                    kladna++;
                else if(myArray[i] < 0)
                    zaporna++;
                else
                    nuly++;

                if(myArray[i] % 2 == 0)
                suda++;
                else
                licha++;


                
            }






            Console.WriteLine("Pocet kladnych cisel: {0}", kladna);
            Console.WriteLine("Pocet zapornych cisel: {0}", zaporna);
            Console.WriteLine("Pocet nul: {0}", nuly);
            Console.WriteLine("\n\nPocet lichych cisel: {0}", licha);
            Console.WriteLine("Pocet sudych cisel: {0}", suda);

           
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();    

        }