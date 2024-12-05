string again = "a";
while(again == "a") {

    Console.Clear();
    razitko();

    ulong a = ziskatCislo("Zadejte prirozene cislo a: ");
    ulong b = ziskatCislo("Zadejte prirozene cislo b: ");


    ulong nsd = vypocitatNsd(a, b);

    ulong nsn = vypocitatNsn(a, b, nsd);

    zobrazVysledky(a, b, nsd, nsn);
    

    

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
    again = Console.ReadLine();    

}

static void razitko(){ //metoda nemusi mit return nakonci pac nic nevraci

    Console.WriteLine("*******************");
    Console.WriteLine("**** NDS a NSN ****");
    Console.WriteLine("****** Rose *******");
    Console.WriteLine("*******************");
    Console.WriteLine();
    Console.WriteLine();

}

static ulong ziskatCislo(string zprava){
    Console.Write(zprava);
    ulong cislo;
    while(!ulong.TryParse(Console.ReadLine(), out cislo)) {
        Console.Write("Nezadali jste prirozene číslo. Zadejte znovu: ");
    }
    return cislo;
}

static ulong vypocitatNsd(ulong x, ulong y){ //x a y nejsou a a b, jsou to odlisne hodnoty
    while(x!=y){
        if(x>y)
            x = x - y;
        else
            y = y - x;
    }
    return x;
}

static ulong vypocitatNsn(ulong x, ulong y, ulong nsd){
    return (x*y)/nsd;
}

static void zobrazVysledky(ulong a, ulong b, ulong nsd, ulong nsn){
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("NSD cisel {0} a {1} je {2}", a, b, nsd);

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"NSN dvou čísel {a} a {b} je {nsn}");

    Console.ForegroundColor = ConsoleColor.Green;
}

