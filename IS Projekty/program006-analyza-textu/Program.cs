string again = "a";
        while(again == "a") {

            Console.Clear();
            Console.WriteLine("*****************************************");
            Console.WriteLine("************** Analýza textu ************");
            Console.WriteLine("****************** Rose *****************");
            Console.WriteLine("*****************************************");
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Zadejte text pro nalyzu: ");
            string mujText = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(mujText);
            Console.WriteLine(mujText[0]);
            Console.WriteLine(mujText.Length);
            Console.WriteLine(mujText[mujText.Length]);

            string samohlasky = "aáeéiíoóuúůyý";
            string souhlasky = "bcčdďfghijklmňnpqrřsštťvwxzž";
            string cislice = "0123456789";

            int pocetSouhlasek = 0;
            int pocetSamohlasek = 0;
            int pocetCislic = 0;
            int pocetOstatnich = 0;

            foreach(char znak in mujText){
                if (samohlasky.Contains(znak)){

            }
            else if(souhlasky.Contains(znak)){

            }
            else if(cislice.Contains(znak)){

            }
            else
                pocetOstatnich++;
            }
            
            Console.WriteLine("\n\nPocet samohlasek je: {0}", pocetSamohlasek);
            Console.WriteLine("Pocet souhlasek je: {0}", pocetSouhlasek);
            Console.WriteLine("Pocet cislic je: {0}", pocetCislic);
            Console.WriteLine("Pocet ostatnich znaku je: {0}", pocetOstatnich);





            
            
           
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();    

        }
