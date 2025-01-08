using System.ComponentModel;
using System.Net.Security;

string again = "a";
        while(again == "a") {

            int n = 10;
            int dm =-2;
            int hm = 20;
           
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("========================================================\n\n");
            
            //deklarace pole o velikosti n prvku
            int[] myArray = new int[n];

            //priprava pro generator
            Random randomNumber = new Random();

            Console.WriteLine("Vygenerovane pole: ");   
            for(int i=0; i < n; i++){
                myArray [i] = randomNumber.Next(dm, hm);
                Console.Write("{0}; ", myArray[i]);
            }

            int max = myArray[0];
            int min = myArray[0];

             for(int i = 0; i<n;i++){
                if(myArray[i] > max){
                    max = myArray[i];
                }
                if(myArray[i] < min){
                    min = myArray[i];
                }
             }
             Console.WriteLine($"\n\nMaximum: {max} Minimum: {min}");

             Console.Write("\nVsechny pozice maxima: ");
             for(int i = 0; i <n;i++){
                if(myArray[i] == max){
                    Console.Write("{0}; ", i+1);
                }
             }
             Console.Write("Vsechny pozice minima: ");
             for(int i = 0; i <n;i++){
                if(myArray[i] == min){
                    Console.Write("{0}; ", i+1);
                }
             }

            //comb sort
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
                    if (myArray[i] < myArray[i + gap])
                    {
                        int temp = myArray[i];
                        myArray[i] = myArray[i + gap];
                        myArray[i + gap] = temp;   
                        sorted = false;
                    }
                }
            }
            Console.Write("\n\nSerazene pole: ");
            for(int i = 0;i<n;i++){
                Console.Write("{0} ", myArray[i]);
            }

            int GetNumber(int poradi, int[] myArray){
                int cislo = myArray[0];
                if(poradi > 1){
                    for(int i = 0; poradi !=1;i++)
                        if(myArray[i] !=cislo){
                            cislo = myArray[i];
                            poradi--;
                        }
                    
                }
                return cislo;
            }
            

            
            //reverze pole
            for(int i = 0; i<n/2;i++){
                int temp = myArray[i];
                myArray[i]=myArray[n-i-1];
                myArray[n-i-1] = temp;
            }

            //fibonaciho posloupnost
            /*int prvek = 10;
            int a =0;
            int b=1;
            int c=1;
            
            if(prvek > 0)
            Console.Write(a);
            if(prvek >1)
            Console.Write($", {b}");
            if(prvek >2){
                for(int i =0;i<prvek-2;i++)
                Console.Write($", {c}");
                a=b;
                b=c;
                c=a+b;
            }*/

            //aritmeticka posloupnost
            int pocetCisel = 10;
            int prvniPrvek = 4;
            int diference = 6;
            int soucet = 0;

            for(int i =0; i<pocetCisel;i++){
                int clen = prvniPrvek+i*diference;
                Console.Write(clen);
                if(i<pocetCisel-1)
                Console.Write("; ");
                else
                Console.Write(";");
                soucet +=clen;
            }

            //nsd nsn
            int a = 10;
            int b=32;
            int pocetPrvku=10;
            int nsd = 0;
            int mini;

            if(a<b)
            mini = a;
            else
            mini=b;
            while(nsd==0){
                if(a%mini==0&&b%mini==0)
                nsd = mini;
                mini--;
            }
            int nsn = a*b/nsd;
            



                
            
            
            
            
            

            
           
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();    

        }