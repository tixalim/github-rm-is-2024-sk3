string again = "a";
    while(again == "a") {

        int n = 10;
        int dm = 1;
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
        Console.WriteLine("========================================================\n\n");
        
        int[] myArray = new int[n];
        Random randomNumber = new Random();

            
        for(int i=0; i < n; i++){
            myArray [i] = randomNumber.Next(dm, hm);
            Console.Write("{0}; ", myArray[i]);
        }

        int max = myArray[0];
        int min = myArray[0];
        

        for(int i=0; i < myArray.Length; i++){
            if(myArray[i] > max){
                max = myArray[i];
            }
            if(myArray[i] < min){
                min = myArray[i];
            }
        }
        Console.WriteLine("\n----------------------");
        Console.WriteLine($"Maximum je: {max}, minimum je: {min}.");

        Console.Write("Pozice vsech maxim: ");
        for(int i = 0; i<n; i++){
            if(myArray[i] == max){
                Console.Write("{0} ", i+1);
            }
        }
        Console.Write("\nPozice vsech minim: ");
        for(int i = 0; i<n; i++){
            if(myArray[i] == min){
                Console.Write("{0} ", i+1);
            }
        }
        Console.WriteLine("\n----------------------");

        //shaker sort
        bool swapped = true;
            int start = 0;
            int end = n - 1;
            while (swapped)
            {
                swapped = false;
                for (int i = start; i < end; i++)
                { 
                    if (myArray[i] < myArray[i + 1])
                    {
                        int temp = myArray[i];
                        myArray[i] = myArray[i + 1];
                        myArray[i + 1] = temp;
                        swapped = true;
                    }
                }
                end--;
                if (!swapped)
                    break;
                swapped = false;
                for (int i = end; i > start; i--)
                {  
                    if (myArray[i] > myArray[i - 1])
                    {
                        int temp = myArray[i];
                        myArray[i] = myArray[i - 1];
                        myArray[i - 1] = temp;
                        swapped = true;
                    }
                }
                start++;
            }

            Console.WriteLine("\nSezarezene pole: ");
            for(int i=0; i<n;i++){
                Console.Write("{0}; ", myArray[i]);
            }

            int GetNumber(int poradi, int[] myArray){
                int cislo = myArray[0];

                if(poradi > 1)
                {
                    for(int i = 0; poradi !=1;i++)
                        if(myArray[i] !=cislo)
                        {
                            cislo = myArray[i];
                            poradi--;
                        }
                }
                return cislo;
            }
            Console.WriteLine("\n----------------------");
            Console.WriteLine($"Druhe nejvetsi cislo je: {GetNumber(2, myArray)}");        
            Console.WriteLine($"Treti nejvetsi cislo je: {GetNumber(3, myArray)}");        
            Console.WriteLine($"Ctvrte nejvetsi cislo je: {GetNumber(4, myArray)}");
            Console.WriteLine("----------------------");


            double median;
            Console.WriteLine();Console.WriteLine();
            if (myArray.Length%2 != 0){
                median = myArray[(myArray.Length/2)];  //pokud pole není sudé, median se nachází v půlce jeho délky
                Console.WriteLine($"Median licheho pole je: {median}");
            }
            else{
                median = (myArray[(myArray.Length/2)-1]+myArray[(myArray.Length/2)])/2.0;//!!  u sudého je to průměr ze součtu dvou prostředních čísel, !! musíme dělit 2.0, protože chceme double, jinak to nevyjde
                Console.WriteLine($"Median sudeho pole je: {median}");          // opět -1 protože pole.Length nam da cislo o jednu vetsi nez je index
            }        

            int zaloha = GetNumber(4, myArray);
            int[] prevod = new int[8]; 
            int index = 0;
            while (zaloha > 0 && index < prevod.Length)
            {
                prevod[index] = zaloha % 2; 
                zaloha = zaloha / 2; 
                index++;
            }
            Console.WriteLine("----------------------");
            Console.Write($"{GetNumber(4, myArray)} je v 2 soustave zapsano: ");
            for (int i = index - 1; i >= 0; i--) 
            {
                Console.Write($"{prevod[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------");

            Console.WriteLine($"Obrazec: vyska (median: {Math.Round(median)}), sirka(treti nejvetsi cislo: {GetNumber(3, myArray)})");
            
            int height = (int)Math.Round(median); //radky
            int width = GetNumber(3, myArray); //sloupce

            

            for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++) 
                        {
                            if ((i < 2 || i >= height-2) && (j >= 2 && j < width-2))
                            {
                                Console.Write("* ");
                            }
                            else if (i >= 2 && i < height - 2)
                            {
                                Console.Write("* ");
                            }
                            else
                            {
                                Console.Write("  ");
                            }
                        }
                        Console.WriteLine();
                    }
            

            
        





        
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
        again = Console.ReadLine();    

    }