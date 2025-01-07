﻿using System.Diagnostics;

string again = "a";
        while(again == "a") {
            Console.WriteLine("***********************************************");
            Console.WriteLine("******* Shell sort *******");
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

            int gap = n / 2;
            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = myArray[i];
                    int j;
                    for (j = i; j >= gap && myArray[j - gap] > temp; j -= gap)
                    {
                        myArray[j] = myArray[j - gap];
                        numberCompare++;
                        numberChange++;
                    }
                    myArray[j] = temp;
                    numberChange++;
                }
                gap /= 2;
            }
            
            myStopwatch.Stop();



            Console.WriteLine("\n\nSeřazené pole: ");
            for(int i=0; i<n; i++) {
                Console.Write("{0}; ", myArray[i]);
            }

            
            Console.WriteLine("\n\nČas potřebný na seřazení pole algoritmem shell sort: {0}", myStopwatch.Elapsed);
            
            Console.WriteLine("\n\nPočet porovnání: {0}", numberCompare);
            Console.WriteLine("Počet výměn: {0}", numberChange);
            
            
            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }