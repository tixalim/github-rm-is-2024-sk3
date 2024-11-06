string again = "a";
    while(again == "a") {

        
        Console.Write("Zadejte vysku obrazce (cele cislo) ");
            int height;
            while(!int.TryParse(Console.ReadLine(), out height)) {
                Console.Write("Nezadali cele cislo, zadejte znovu:");
            }
        
        for (int i = 0; i < height; i++)
        {
            int mezery = Math.Abs(i - height / 2);

            for (int j = 0; j < mezery; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < height - 2 * mezery; j++)
            {
                Console.Write("*");
            }
            for (int j = 0; j < mezery; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
        }

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
    again = Console.ReadLine();    

}

