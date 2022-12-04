// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vítejte v kalkulačce");
string pokracovat = "ano";
while (pokracovat == "ano")
{
    Console.WriteLine("Zadejte první číslo:");
    string vstup_1 = Console.ReadLine();
    double cislo1 = Convert.ToDouble(vstup_1);

    Console.WriteLine("Zadejte druhé číslo");
    string vstup_2 = Console.ReadLine();
    double cislo2 = Convert.ToDouble(vstup_2);

    Console.WriteLine("Vyberte si operaci:");
    Console.WriteLine("1 - sčítání");
    Console.WriteLine("2 - odčítání");
    Console.WriteLine("3 - násobení");
    Console.WriteLine("4 - děleni");
    int operace = int.Parse(Console.ReadLine());
    double vysledek = 0;

    switch (operace)
    {
        case 1:
            vysledek = cislo1 + cislo2;
            break;

        case 2:
            vysledek = cislo1 - cislo2;
            break;

        case 3:
            vysledek = cislo1 * cislo2;
            break;

        case 4:
            vysledek = cislo1 / cislo2;
            break;
    }

    if ((operace > 0) && (operace < 5))
        Console.WriteLine("Výsledek: {0}", vysledek);
    else
        Console.WriteLine("Neplatná volba");
    Console.WriteLine("Chcete počítat další přiklad?");
    pokracovat = Console.ReadLine();
}

Console.WriteLine("Děkuji za puižití kalkulačky, aplikaci ukončíte libovolnou klávesou.");
Console.ReadKey();