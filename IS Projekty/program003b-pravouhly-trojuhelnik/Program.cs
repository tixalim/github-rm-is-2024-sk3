string again = "a";
    while(again == "a") {

        Console.WriteLine("Zadejte vysku trojuhelniku (cele cislo): ");
        uint wigth;
        while(!uint.TryParse(Console.ReadLine(), out wigth)){
            Console.WriteLine("Nezadali jste cele cislo, zadejte znovu: ");
        }

        for (int i = 1; i <= wigth; i++)
        {      
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
    again = Console.ReadLine();    

}
