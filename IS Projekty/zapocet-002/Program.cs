string again = "a";
        while(again == "a") {

            
            int n = 10;
            int dm = -2;
            int hm = 15;
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
            
            //deklarace pole o velikosti n prvku
            int[] myArray = new int[n];

            //priprava pro generator
            Random randomNumber = new Random();

                
            for(int i=0; i < n; i++){
                myArray [i] = randomNumber.Next(dm, hm);
                Console.Write("{0}; ", myArray[i]);
            }

            int max = myArray[0];
            int min = myArray[0];

            for(int i=0;i<n;i++){
                if(myArray[i] > max){
                    max = myArray[i];
                }
                if(myArray[i] < min){
                    min = myArray[i];
                }
            }
            Console.WriteLine($"\nMaximum: {max} Minimum: {min}");
            Console.Write("Vsechny pozice maxima: ");
            for(int i = 0;i<n;i++){
                if(myArray[i] == max){
                    Console.Write("{0} ",i+1);
                }
            }
            Console.Write("\nVsechny pozice minim: ");
            for(int i = 0;i<n;i++){
                if(myArray[i] == min){
                    Console.Write("{0} ",i+1);
                }
            }


            //shaker sort
            bool swapped = true;
            int start = 0;
            int end = n-1;
            while(swapped){
                swapped=false;
                for(int i =start;i<end;i++){
                    if(myArray[i]<myArray[i+1]){
                        int temp = myArray[i];
                        myArray[i]=myArray[i+1];
                        myArray[i+1]=temp;
                        swapped=true;
                    }
                }
                end--;
                if(!swapped)
                    break;
                swapped =false;
                for(int i=end;i>start;i--){
                    if(myArray[i]>myArray[i-1]){
                        int temp = myArray[i];
                            myArray[i]=myArray[i-1];
                            myArray[i-1]=temp;
                            swapped=true;
                    }
                }
                start++;
            }
            
            Console.WriteLine("\n\nSerazene pole shaker sortem: ");
            for(int i =0;i<n;i++){
                Console.Write("{0}; ",myArray[i]);
            }

            int GetNumber(int poradi, int[] myArray){
                int cislo=myArray[0];
                if(poradi>1){
                    for(int i=0;poradi!=1;i++)
                        if(myArray[i] !=cislo){
                            cislo=myArray[i];
                            poradi--;
                        }
                    }
                    return cislo;
                }
           
            Console.WriteLine($"\n\nDruhe nejvetsi cislo: {GetNumber(2, myArray)}");
            Console.WriteLine($"Treti nejvetsi cislo: {GetNumber(3, myArray)}");
            Console.WriteLine($"Pate nejvetsi cislo: {GetNumber(5, myArray)}");

            int zaloha = max;
            int cifra;
            int suma = 0;
            int soucin = 1;
            if (max<0)        
                max = -max;    
            while(max != 0)
            {
                cifra = max % 10;     
                suma = suma + cifra;
                soucin = soucin * cifra;
                max = (max - cifra)/10;
            }
            Console.WriteLine($"\n\nMaximum: {zaloha}");
            Console.WriteLine($"Jeho ciferny soucet: {suma}");
            Console.WriteLine($"Jeho ciferny soucin: {soucin}");


            Console.WriteLine("\nVýsledná aritmetická posloupnost:");

            int pocetCisel = 10;
            int prvniPrvek = GetNumber(2,myArray);
            int diference = GetNumber(5, myArray);
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
            Console.WriteLine($"\nPocet cisel v posloupnosti: {pocetCisel}");
            Console.WriteLine($"Prvni prvek: {prvniPrvek}");
            Console.WriteLine($"Diference: {diference}");
            Console.WriteLine($"Součet zobrazených hodnot: {soucet}");


            int height = GetNumber(3,myArray);
            int width = GetNumber(3,myArray);
            Console.WriteLine($"\n\nVyska je: {height}\n\n");

            for(int i = 0; i < height; i++){
                for(int j = 0; j < height; j++){
                    Console.Write("* ");
                }
                for(int j = 1; j<i ; j++){

                }

                Console.WriteLine();
                


            }






           
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();    

        }