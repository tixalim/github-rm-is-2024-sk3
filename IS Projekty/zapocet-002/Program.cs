while(true){


        int width;
        int height;

        
        while(!int.TryParse(Console.ReadLine(), out height)) {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
        }
        while(!int.TryParse(Console.ReadLine(), out width)) {
                        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
                    }
        
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
    //Console.ReadLine();
}