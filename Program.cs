Console.Write("Imie Bohatera:");
string bohater1 = Console.ReadLine()!;

Console.Write("Klasa:");
string klasa1 = Console.ReadLine()!;

Console.Write("Ile masz HP:");
string wpisanaLiczba = Console.ReadLine()!;
int hp1 = int.Parse(wpisanaLiczba);

Console.Write("Siła:");
string wpisanaLiczba2 = Console.ReadLine()!;
int sila1 =int.Parse(wpisanaLiczba2);

Console.Write("Ile masz złota:");
string wpisanaLiczba3 = Console.ReadLine()!;
decimal zloto1 = decimal.Parse(wpisanaLiczba3);


Console.WriteLine("+================================+");
Console.WriteLine("|        HELLOADVENTURER         |");
Console.WriteLine("+================================+");
Console.WriteLine($"| Bohater:\t{bohater1}\t\t |");
Console.WriteLine($"| Klasa:\t{klasa1}\t |");
Console.WriteLine("+================================+");
Console.WriteLine($"| HP:\t\t{hp1}\t\t |");
Console.WriteLine($"| Siła:\t\t{sila1}\t\t |");
Console.WriteLine($"| Złoto:\t{zloto1}\t\t |");
Console.WriteLine("+================================+");
Console.WriteLine($"| Łączna moc:\t{hp1*sila1}\t\t |");
Console.WriteLine("+================================+");
