string again = "a";
    while(again == "a") {

        
        Console.Write("Zadejte vysku obrazce (cele cislo) ");
            int height;
            while(!int.TryParse(Console.ReadLine(), out height)) {
                Console.Write("Nezadali cele cislo, zadejte znovu:");
            }
        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= height; j++)
            {
                if (i == 1 || i == height)
                {
                    Console.Write("* ");
                }
                else if (j == height - i + 1)
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


