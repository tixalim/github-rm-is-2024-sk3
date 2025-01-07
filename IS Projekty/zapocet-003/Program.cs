using System.Globalization;

string again = "a";
        while(again == "a") {

            int n = 10;
            int dm = -2;
            int hm = 10;


            /*Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
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
            }*/
           
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("========================================================\n");
            
            int[] myArray = new int[n];
            Random randomNumber = new Random();
            Console.WriteLine("\nPole vygenerovanych cisel: ");
            for(int i=0; i < n; i++){
                myArray [i] = randomNumber.Next(dm, hm);
                Console.Write("{0}; ", myArray[i]);
            }

            int max = myArray[0];
            int min = myArray[0];

            for(int i = 0; i < n; i++){
                if(myArray[i] > max){
                    max = myArray[i];
                }
                if(myArray[i] < min){
                    min = myArray[i];
                }
            }
            
            Console.WriteLine($"\n\nMaximum pole je: {max}, minimum pole je: {min}");
            Console.WriteLine("========================================================\n\n");
            
            int bzbytku = 0;
            int prirozdelitel = 3;
            string delitelnaCisla = "";

            for(int i =0; i<myArray.Length; i++){
                if(myArray[i] % prirozdelitel == 0){
                    bzbytku++;
                    delitelnaCisla += myArray[i] + ", ";
                }
            }
            Console.WriteLine($"Pocet cisel delitelnych bez zbytku cislem {prirozdelitel}: {bzbytku}");
            Console.WriteLine($"Jsou to cisla: {delitelnaCisla}");
            Console.WriteLine("========================================================\n");

            //selection sort
            for (int i = 0; i < n - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (myArray[j] > myArray[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                int temp = myArray[maxIndex];
                myArray[maxIndex] = myArray[i];
                myArray[i] = temp;
            }
    
            Console.WriteLine("Serazene pole selection sortem: ");
            for(int i =0;i<n;i++){
                Console.Write("{0}; ", myArray[i]);
            }


            int GetNumber(int poradi, int[] myArray){
                int cislo = myArray[0];
                if(poradi > 1){
                    for(int i=0; poradi !=1;i++)
                        if(myArray[i] !=cislo){
                            cislo = myArray[i];
                            poradi --;
                        }
                }
                return cislo;
            }
            //Console.WriteLine($"Druhe nejvetsi cislo: {GetNumber(2, myArray)}");

            int zaloha = GetNumber(2, myArray);
            int[] prevod = new int[8]; 
            int index = 0;
            while (zaloha > 0 && index < prevod.Length)
            {
                prevod[index] = zaloha % 2; 
                zaloha = zaloha / 2; 
                index++;
            }
            Console.WriteLine("========================================================");
            Console.Write($"Druhe nejvetsi cislo: {GetNumber(2, myArray)}, je v 2 soustave zapsano: ");
            for (int i = index - 1; i >= 0; i--) 
            {
                Console.Write($"{prevod[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("========================================================");  

            Console.WriteLine($"Trojuhelnik s vyskou, coz je treti nejvetsi cislo: {GetNumber(3, myArray)}");          
            
            int height = GetNumber(3, myArray);

            for(int i = 1; i <= height; i++){

                for(int j = 0; j < height - i; j++){
                    Console.Write("  ");
                }
                for(int k = 0; k < i; k++){
                    Console.Write("* ");
                }
                Console.WriteLine();
                
                
            }






           
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();    

        }