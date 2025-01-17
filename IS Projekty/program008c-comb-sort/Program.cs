﻿using System.Diagnostics;

string again = "a";
        while(again == "a") {
            Console.WriteLine("***********************************************");
            Console.WriteLine("******* Comb sort *******");
            Console.WriteLine("***********************************************");
            Console.WriteLine("******************** Rose *********************");
            Console.WriteLine("***********************************************\n\n");
            Console.WriteLine();

            
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo): ");
            }

            Console.WriteLine("\n\n====================");
            Console.WriteLine("Uživatelský vstup: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("====================\n\n");

            int[] myArray = new int[n];

            Random randomNumber = new Random();

            Console.WriteLine("Náhodná čísla: ");

            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);
            }
            
            Stopwatch myStopwatch = new Stopwatch(); 
            myStopwatch.Start();

            int numberCompare = 0;
            int numberChange = 0;

            
            int gap = myArray.Length;
            const double shrink = 1.3;
            bool sorted = false;

            while (!sorted || gap > 1)
            {
                gap = (int)(gap / shrink);
                if (gap < 1)
                {
                    gap = 1;
                }
                sorted = true;
                for (int i = 0; i + gap < myArray.Length; i++)
                {
                    numberCompare++;

                    if (myArray[i] > myArray[i + gap])
                    {
                        int temp = myArray[i];
                        myArray[i] = myArray[i + gap];
                        myArray[i + gap] = temp;

                        numberChange++;
                        sorted = false;
                    }
                }
            }
            myStopwatch.Stop();



            Console.WriteLine("\n\nSeřazené pole: ");
            for(int i=0; i<n; i++) {
                Console.Write("{0}; ", myArray[i]);
            }

            
            Console.WriteLine("\n\nČas potřebný na seřazení pole algoritmem comb sort: {0}", myStopwatch.Elapsed);
            
            Console.WriteLine("\n\nPočet porovnání: {0}", numberCompare);
            Console.WriteLine("Počet výměn: {0}", numberChange);
            
            Console.ResetColor();
            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }