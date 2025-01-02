Console.WriteLine("******************");
Console.WriteLine("**** Příprava ****");
Console.WriteLine("******************");


int n = 10;
int dm = -20;
int hm = 20;

/* pro urychlení nastaveno napevno
Console.Write("\nZadejte počet generovaných čísel (n): ");
while(!int.TryParse(Console.ReadLine(), out n))
    Console.Write("Zřejmě jste nezadali celočíselnou hodnotu.\nZadejte n: ");
    
Console.Write("\nZadejte dolní mez (dm): ");
while(!int.TryParse(Console.ReadLine(), out dm))
    Console.Write("Zřejmě jste nezadali celočíselnou hodnotu.\nZadejte znovu dm: ");

Console.Write("\nZadejte dolní mez (hm): ");
while(!int.TryParse(Console.ReadLine(), out hm))
    Console.Write("Zřejmě jste nezadali celočíselnou hodnotu.\nZadejte znovu hm: ");

Console.WriteLine("\nPočet čísel: {0}", n);
Console.WriteLine("\nDolní mez: {0}", dm);
Console.WriteLine("\nHorní mez: {0}", hm); 
*/

// příprava pro generátor
Random nahodneCislo = new Random();

int[] pole = new int[n];    

Console.WriteLine("\n\n===========================================");
Console.WriteLine("Generovaná čísla: ");
for(int i=0; i<n; i++) {
    pole[i] = nahodneCislo.Next(dm, hm+1);
    Console.Write("{0}; ", pole[i]);
}

Console.WriteLine("\n\n===========================================");
Console.WriteLine("Kvadratická rovnice: ");
int a = 2;
int b = dm;
int c = hm;
double d = b*b-4*a*c;
double kvadresult1;
double kvadresult2;
Console.WriteLine($"Diskriminant: {d}");
if (d>0){
    kvadresult1 = (-b + Math.Sqrt(d))/(2*a);
    kvadresult2 = (-b - Math.Sqrt(d))/(2*a);
    Console.WriteLine($"První kořen: {kvadresult1}");  //u vsech vypisu pouzivam formatovany string s $
    Console.WriteLine($"Druhý kořen: {kvadresult2}");

} else if (d==0) {
    kvadresult1 = (-b + Math.Sqrt(d))/(2*a);
    Console.WriteLine($"Stejný kořen: {kvadresult1}");
} else
    Console.WriteLine($"Rovnice nemá kořen v reálných číslech");

Console.WriteLine("\n\n===========================================");
Console.WriteLine("Vykreslení geometrických obrazců: \n");
//čtverec, a = vyska, b = sirka
a = 4;
b = 4;
for (int i = 0; i < b; i++)
{
    for (int j = 0; j < a; j++)
        Console.Write("* ");
    Console.WriteLine();
}
Console.WriteLine();
//trojúhelník pravoúhlý, a = vyska
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < i+1; j++)
        Console.Write("* ");
    Console.WriteLine();
}
Console.WriteLine();
//trojúhelník rovnoramenný, a = vyska
for (int i = 1; i <= a; i++)
{
    for (int j = 1; j <= a - i; j++)
        Console.Write("  ");

    for (int k = 1; k < 2 * i; k++)
        Console.Write("* ");
    Console.WriteLine();
}

Console.WriteLine("\n\n===========================================");
Console.WriteLine("Výpočet mocniny: \n");
int mocnina = 6;
int cislo = 2;
int result = cislo;

for (int i = 1; i < mocnina; i++)
    result = result * cislo;

Console.WriteLine($"{cislo} na {mocnina} je {result}\n");
Console.WriteLine($"{cislo} na {mocnina} je {Math.Pow(cislo, mocnina)}\n"); //druhá možnost pomocí metod v c#

Console.WriteLine("\n\n===========================================");
Console.WriteLine("Ciferný součet a součin: \n");
cislo = 1234;
int zaloha = cislo;
int cifra;
int suma = 0;
int soucin = 1;
if (cislo<0)        //prevedeni na kladne cislo
    cislo = -cislo;    
while(cislo != 0)
{
    cifra = cislo % 10;     //např. 456 % 10 = 6 (cifra)
    suma = suma + cifra;    //pricteni cifry
    soucin = soucin * cifra;
    cislo = (cislo - cifra)/10;  //456-6/10 = 45 a jede se znovu
}
Console.WriteLine($"cislo: {zaloha}");
Console.WriteLine($"ciferny soucet: {suma}");
Console.WriteLine($"ciferny soucin: {soucin}");

Console.WriteLine("\n\n===========================================");
int prvek = 10;
Console.WriteLine($"Fibonacciho posloupnost pro {prvek}. prvek: \n");
a = 0;
b = 1;
c = 1;
Console.Write("Posloupnost: ");
if (prvek > 0)
    Console.Write(a);
if (prvek > 1)
    Console.Write($", {b}");
if (prvek > 2){
    for (int i = 0; i < prvek-2; i++)  //pokud je prvek 5, tak první dva již máme vytisklé, zbylé 3 vytiskne cyklus for pro i<3 (i=0,1,2) 
    {
        Console.Write($", {c}"); //c vytiskne
        a = b;                   //posune prvky dolu b->a c->b a vypocte dalsi prvek souctem dvou prechozich
        b = c;          
        c = a + b;     
    }
}

Console.WriteLine("\n\n===========================================");
Console.WriteLine("NSD a NSn: \n"); //nejvetsi spolecny delitel, nejmensi spolecny nasobek
a = 15;
b = 42;
int nsd = 0;
int min;

if(a<b)
    min = a;
else
    min = b;

while (nsd == 0)
{
    if (a%min == 0 && b%min == 0)   //obe cisla se děli minimem ze dvou cisel (coz je nejvetsi spolecny nasobek pro pripad cisel 20 a 40, 15 a 30 apod.)
        nsd = min;                          //jakmile neni zbytek, urci se nsd, jiz není 0 a cyklus skonci
    min--;                          //poté se cislo min snizuje dokud se nenajde takové, po kterém vydělením obou čísel nevznikne zbytek
}
int nsn = a*b/nsd;       //obecny vzorec
Console.WriteLine($"První číslo: {a}");
Console.WriteLine($"Druhé číslo: {b}");
Console.WriteLine($"Největší společný dělitel: {nsd}\nNejmenší společný násobek: {nsn}\n");

Console.WriteLine("\n\n===========================================");
Console.WriteLine($"Počet čísel v poli, které jsou:\n1) bezezbytku dělitelná určitým číslem\n2) kladna a zaporna\n3) suda a licha\n\n");
int bzbytku = 0;
int prirozdelitel = 6;
int kladna = 0;
int zaporna = 0;
int nuly = 0;
int suda = 0;
int licha = 0;
foreach (var number in pole)
{
    if (number%prirozdelitel == 0)
        bzbytku++;
    if (number>0)
        kladna++;
    else if (number<0)
        zaporna++;
    else
        nuly++;
    if (number%2==0)
        suda++;
    else
        licha++;
}

for(int i=0; i<n; i++)
    Console.Write("{0}; ", pole[i]);  //vypis pole pro kontrolu

Console.WriteLine();

Console.WriteLine($"bez zbytku cislem {prirozdelitel}: {bzbytku}");
Console.WriteLine($"kladna: {kladna}");
Console.WriteLine($"zaporna: {zaporna}");
Console.WriteLine($"nuly: {nuly}");
Console.WriteLine($"suda: {suda}");
Console.WriteLine($"licha: {licha}");

Console.WriteLine("\n\n===========================================");
Console.WriteLine($"Prevod z 10 do 2 a obracene\n");

cislo = 123;
zaloha = cislo;
int[] prevod = new int[8]; //8 bitové cislo, zvedame podle potreby
for (int i = 0; cislo >= 1; i++)
{
    prevod[i] = cislo%2;
    cislo = (cislo-cislo%2)/2;
}
Console.Write($"{zaloha} je v 2 soustave zapsano: ");
for (int i = prevod.Length-1; i >= 0; i--)
    Console.Write($"{prevod[i]} ");

Console.WriteLine();

suma = 0;
int nasobitel = 1;
for (int i = 0; i < prevod.Length-1; i++)
{
    suma = suma + prevod[i] * nasobitel;
    nasobitel = 2 * nasobitel;  //nasobitel se zvetsuje stejne jako nasobime 2 na nultou, 2 na prvou, 2 na druhou, ctvrtou
}
Console.WriteLine($"Prevod zpet je je: {suma}");

Console.WriteLine("\n\n===========================================");
Console.WriteLine($"Reverze pole:\n");

for(int i=0; i<n; i++) {
    Console.Write("{0}; ", pole[i]);  //vypis pole pro kontrolu
}
Console.WriteLine();

int[] polereverse = new int[pole.Length];
zaloha = 0;

for (int i = 0; i < pole.Length/2; i++)   //delame pouze puklu pole, jelikoz se tím prohodí celé pole (hazem cislo z první půlky do druhé)
{
    zaloha = pole[i];
    pole[i] = pole[pole.Length-1-i];      //-1 protoze pole lenght nepočítá nulu a tak je vzdy o 1 vetsi nez index, který chceme
    pole[pole.Length-1-i] = zaloha;
}

for(int i=0; i<n; i++) {
    Console.Write("{0}; ", pole[i]); //vypis reverze
}

Console.WriteLine("\n\n===========================================");
Console.WriteLine($"Součin pomocí součtu:\n");
a = 7;
b = 9;
suma = a;
for (int i = 1; i < b; i++)
    suma = suma+a;

Console.WriteLine($"{a} krát {b} = {suma}");

Console.WriteLine("\n\n===========================================");
Console.WriteLine($"Dělení pomocí odečítání:\n");
a = 30;
zaloha = a;
b = 7;
suma = 0;
if (a>b)
{
    for (int i = 1; a > 0; i++)
    {
        a = a-b;
        if (a>0)
            suma++;
    }
    Console.WriteLine($"{zaloha}/{b}={suma}");
}
else
    Console.WriteLine($"{zaloha}/{b}=0");

Console.WriteLine("\n\n===========================================");
Console.WriteLine($"Test kolikrát se určitá číslice vyskytuje v daném čísle:\n");

cislo = 123435;
zaloha = cislo;
cifra = 0;
suma = 0;
a = 3;

for (int i = 0; cislo > 0 ; i++)
{
    cifra = cislo%10;       //stejná metoda jako u ciferného součtu a součinu
    if (a == cifra)
        suma++;
    cislo = (cislo-cifra)/10;
}
Console.WriteLine($"Cifra {a} se v čísle {zaloha} vyskytuje {suma}krát.");

Console.WriteLine("\n\n===========================================");
Console.WriteLine($"Vyhledání extrémů v poli, max min jejich počet a pozice:\n");
min = pole[0];
int max = pole[0];
int pocetmin = 0;
int pocetmax = 0;
int[] pozicemin = new int[pole.Length];     //maximalni mozna delka pole (kdyby celé pole bylo min)
int[] pozicemax = new int[pole.Length];

for (int i = 1; i < pole.Length-1; i++)
{
    if (min > pole[i])
        min = pole[i];
    if (max < pole[i])
        max = pole[i];
}
int m = 0;
int o = 0;
for (int i = 0; i < pole.Length-1; i++)
{
    if (pole[i] == min)
    {
        pocetmin++;
        pozicemin[m] = i+1;     //určení vizuální pozice, ne indexové, proto +1
        m++;
    }
    if (pole[i] == max)
    {
        pocetmax++;
        pozicemax[o] = i+1;     //určení vizuální pozice, ne indexové, proto +1
        o++;
    }
}
for(int i=0; i<n; i++) {
    Console.Write("{0}; ", pole[i]);
}
Console.WriteLine($"\n\nMin v poli je: {min}");
Console.WriteLine($"Počet min v poli je: {pocetmin}");
Console.Write("Pozice min je: ");
for(int i=0; i<n; i++) {
    if (pozicemin[i] != 0)      //výpis pozic, které nejsou nula (protoze zbytek pole je vyplněné nulami)
        Console.Write("{0}; ", pozicemin[i]);
}

Console.WriteLine($"\n\nMax v poli je: {max}");
Console.WriteLine($"Počet max v poli je: {pocetmax}");
Console.Write("Pozice max je: ");
for(int i=0; i<n; i++) {
    if (pozicemin[i] != 0)      //výpis pozic, které nejsou nula (protoze zbytek pole je vyplněné nulami)
        Console.Write("{0}; ", pozicemax[i]);
}

Console.WriteLine("\n\n===========================================");
Console.WriteLine($"Vyhledávání v poli, pocet a pozice:\n");
a = 8; //hledane cislo
int pocetcisel = 0;
int[] pozicecisla = new int[pole.Length];       //maximalni mozna delka pole (kdyby celé pole bylo hledane cislo)
o = 0;
for (int i = 0; i < pole.Length-1; i++)
{
    if (pole[i] == a){
        pocetcisel++;
        pozicecisla[o] = i+1;       //určení vizuální pozice, ne indexové, proto +1
        o++;
    }
}
if (pocetcisel != 0){
    Console.WriteLine($"Hledané číslo {a} je v poli {pocetcisel}krat.");
    Console.Write("Pozice výskytu jsou: ");
    foreach (var number in pozicecisla)
        if (number != 0)        //výpis pozic, které nejsou nula (protoze zbytek pole je vyplněné nulami)
            Console.Write($"{number}, ");
}
else
    Console.WriteLine($"Hledané cislo {a} v poli není");

Console.WriteLine("\n\n===========================================");
Console.WriteLine($"Průměr a medián v poli:\n");
double suma1 = 0;
double prumer;
foreach (var number in pole)  //misto foreach lze pouzivat cyklus for
    suma1 = suma1 + number;

prumer = suma1/pole.Length;
Console.WriteLine($"Prumer pole je: {prumer}");
double median;

Array.Sort(pole); //serazeni od nejmensi po nejvetsi, nechci se ucit sorty, tady nam staci jakekoliv serazeni, hledame prostě půlku serazeneho pole
Console.Write("Serazene Pole: ");
for(int i=0; i<n; i++) {
    Console.Write("{0}; ", pole[i]);
}
Console.WriteLine();Console.WriteLine();
if (pole.Length%2 != 0){
    median = pole[(pole.Length/2)+1];  //pokud pole není sudé, median se nachází v půlce jeho délky(+1 protoze indexy zacinaji od nuly)
    Console.WriteLine($"Median licheho pole je: {median}");
}
else{
    median = (pole[(pole.Length/2)-1]+pole[(pole.Length/2)])/2.0;//!!  u sudého je to průměr ze součtu dvou prostředních čísel, !! musíme dělit 2.0, protože chceme double, jinak to nevyjde
    Console.WriteLine($"Median sudeho pole je: {median}");          // opět -1 protože pole.Length nam da cislo o jednu vetsi nez je index
}

Console.WriteLine("\n\n===========================================");
Console.WriteLine($"Pořadí čísel v poli:\n");

for (int i = 0; i < pole.Length/2; i++) //reverze pole, jelikoz nam metoda Array.Sort(pole) seradila pole od nejmensi po nejvetsi a my potrebujeme opak
{                                       //pokud se nechces ucit reverzi, je na to metoda Array.Reverse(pole);
    zaloha = pole[i];                   //pokud umis sorty, řadíš to od nejvetsi po nejmensi rovnou
    pole[i] = pole[pole.Length-1-i];
    pole[pole.Length-1-i] = zaloha;
}

Console.Write("Reverze Pole: ");  //vypis pro kontrolu
for(int i=0; i<n; i++) {
    Console.Write("{0}; ", pole[i]);
}


static int GetNumber(int poradi, int[] pole){
    int cislo = 9;
    int p = 1;
    if (poradi == 1)                    //pokud chceme 1 prvek, jedná se o první prvek v seřazeném poli
        return pole[0];
    else{
        for (int i = 0; p < poradi; i++)
        {
            if (pole[i] != pole[i+1]){  //hledáme změnu čísel, tedy stav kdy se např v poli z 8,8,8 stane 8,8,7,7,7
                cislo = pole[i+1];      //jakmile tato změna nastane neboli aktualni prvek se nerovná prvku následujícímu, přičteme k p 1
                p++;                    //p je ukazatel, kolik probehlo změn, pokud hledáme třetí číslo, chceme dvě změny např. 8,8,8,7,7,7,6 - třetí číslo je 6
            }                           //pri jakekoliv zmene se nasledujici cislo nahraje do "cislo", jakmile probehne dostatecny pocet zmen, cyklus se ukonci
                                        //takhle jsem si to vymyslel já, možna je lepší metoda nevim
        }
    }
    return cislo;
}
Console.WriteLine();
Console.WriteLine($"1. cislo v poli je {GetNumber(1, pole)}");
Console.WriteLine($"2. cislo v poli je {GetNumber(2, pole)}");
Console.WriteLine($"3. cislo v poli je {GetNumber(3, pole)}");
Console.WriteLine($"4. cislo v poli je {GetNumber(4, pole)}");

Console.WriteLine("\n\n===========================================");
Console.WriteLine($"Faktorial:\n");
ulong cislofak = 5;

static ulong faktorialCisla(ulong cislofak){

    ulong faktorial = cislofak;
    while (cislofak > 1)
    {
        faktorial = faktorial * (cislofak-1);
        cislofak--;
    }
    return faktorial;
}
Console.WriteLine($"Faktoriál čísla {cislofak} je {faktorialCisla(cislofak)}");

Console.WriteLine("\n\n===========================================");
Console.WriteLine($"Aritmetická a geometrická řada:\n");

int pocet = 10; //pocet prvku rady
int diference = 3;
int pprvek = 1; //první prvek
int soucet = pprvek;

Console.WriteLine($"Počet: {pocet}");
Console.WriteLine($"Diference: {diference}");
Console.WriteLine($"První prvek: {pprvek}");
Console.Write("Aritmetická řada: ");
Console.Write(pprvek);
for (int i = 1; i < pocet; i++) //aritmeticka rada, první prvek je již vypsán
{
    pprvek = pprvek + diference;
    soucet = soucet + pprvek;
    Console.Write(", {0}", pprvek);
}
Console.WriteLine($"\nSoučet řady: {soucet}\n");

pocet = 10; //pocet prvku rady
diference = 2;
pprvek = 1; //první prvek
soucet = pprvek;
Console.WriteLine($"Počet: {pocet}");
Console.WriteLine($"Diference: {diference}");
Console.WriteLine($"První prvek: {pprvek}");
Console.Write("Geometrická řada: ");
Console.Write(pprvek);
for (int i = 1; i < pocet; i++) //geometrická rada
{
    pprvek = pprvek * diference;
    soucet = soucet + pprvek;
    Console.Write(", {0}", pprvek);
}
Console.WriteLine($"\nSoučet řady: {soucet}");

Console.WriteLine("\n\n===========================================");
Console.WriteLine($"Intervaly:\n");     //tento kód funguje jen v případě, kdy je dolní mez=0, ale je to kód žišky, tak je to asi ok
n = 20; // 20 cisel v poli
dm=0;
hm=20;
int[] pole2 = new int[n]; //nove pole
Random rn = new Random(); // rn může být cokoliv, žiška misto toho píše "nahodne"
int int01=0, int02=0, int03=0, int04=0; //počet čísel ve čtyřech intervalech

for(int i=0; i<n; i++)
{
    pole2[i] = rn.Next(dm, hm+1);
    Console.Write("{0}; ",pole2[i]); //výpis pole

    if(pole2[i] <= (0.25 * hm))       //neboli pokud je cislo mezi nulou a 5 (0,25*20), pokud platí, zbytek kodu podminky se neprovede
        int01++;
    else if(pole2[i] <= (0.5 * hm))   //mezi 0 a 10 ---- sem padají pouze čísla, která neprošly horním if, takže ve skutečnosti to je mezi 5 a 10
        int02++;
    else if(pole2[i] <= (0.75 * hm))  //mezi 0 a 15 ---- mezi 10 a 15
        int03++;
    else                              //zbytek (mezi 0 a 20) ---- mezi 15 a 20
        int04++;
}

Console.WriteLine("\n\nInterval <{0};{1}>: {2}", dm, 0.25*hm, int01);     //prosím používejte formátovaný string, je mi z toho zle

Console.WriteLine("Interval <{0};{1}>: {2}", 0.25*hm+1, 0.5*hm, int02);

Console.WriteLine("Interval <{0};{1}>: {2}", 0.5*hm+1, 0.75*hm, int03);

Console.WriteLine("Interval <{0};{1}>: {2}", 0.75*hm+1, hm, int04);


Console.ReadLine();