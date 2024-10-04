Console.WriteLine("Welkom to Knight vs Goblin!");
Console.WriteLine("---------------------------");
Console.Write("Enter knight healt: ");
string input = Console.ReadLine();


Random randomNumberGenerator = new Random();

//? = if  : = else

int knighthealt;
//bool knighthealtVal = int.TryParse(input, out knighthealt);
if (int.TryParse(input, out knighthealt))
{
    if (knighthealt <= 0 || knighthealt > 100)
    {
        //Waarde van getal te klein of te groet
        Console.WriteLine("Invalid number, default value 100 is used.");
        knighthealt = 100;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Knight healt: {knighthealt}");
        Console.ResetColor();
    }
}
else
{
    Console.WriteLine("Invalid number, default value 100 is used.");
    knighthealt = 100;
}

//initialiseer levenspunten van goblin
int goblinHealt = randomNumberGenerator.Next(1, 101);
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Goblin healt: {goblinHealt}");
Console.ResetColor();

//for(int attempts = 1; attempts <= 4; attempts++) 
do
{
    //Console.WriteLine($"Ronde {attempts}");
    int attackKnight = 10;
    int attackGoblin = randomNumberGenerator.Next(5, 16);

    Console.WriteLine("Choose your next move carrefully: ");
    Console.WriteLine("1. Attack");
    Console.WriteLine("2. Heal");
    Console.Write("Enter your choose: ");
    string selectieAction = Console.ReadLine();

    switch (selectieAction)
    {
        case "1":
            goblinHealt -= attackKnight;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"You attacked the goblin for {attackKnight} damage!");
            break;
        case "2":
            knighthealt += 10;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You healed yourself for 10 healt points!");

            break;
        default:
            Console.WriteLine("Invalid move! Please choose a valid points!");
            break;

    }
    if (goblinHealt > 0)
    {
        knighthealt -= attackGoblin;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Your were attaked by the goblin for {attackGoblin} damage!");
        Console.ResetColor();
    }


    if (knighthealt <= 0)
    {
        Console.WriteLine("De knight is gestorven!");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Knight healt: {knighthealt}");
        Console.ResetColor();
    }
    if (goblinHealt <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("De goblin is gestorven!");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Goblin healt: {goblinHealt}");
        Console.ResetColor();
    }
} while(knighthealt > 0 && goblinHealt > 0);




/* 
 * Deel 1
 * 
 * We gaan een applicatie maken waarin de speler als ridder tegen een goblin moet vechten.
 * We starten met een controle te implementeren die kijkt of de speler nog leeft.
 *  - Declareer en initialiseer een waarde knightHealth (0) en goblinHealth (20).
 *  - Indien de levenspunten van de speler (knightHealth) kleiner of gelijk zijn aan nul,
 *    dan toon je aan de speler dat hij/zij is gestorven. 
 *  - Doe hetzelfde voor de goblin.
 *  - Extra: gebruik de Random klasse om de levenspuntenvan de ridder en goblin in te stellen.
 */

/* 
 * Deel 2
 * 
 * - Indien de speler niet gestorven is, dan druk je af hoeveel levenspunten (knightHealth) 
 *   speler nog heeft. Gebruik hier else voor.
 * - Laat de speler zelf levenspunten ingeven voor de ridder (knightHealth). Zo kiest elke speler 
 *   zelf hoe moeilijk het gevecht is. 
 * - De waarde knightHealth moeten tussen 0 en 100. Indien de speler een ongeldige waarde ingeeft, 
 *   dan wordt de standaard waarde 100 gebruikt.
 *    - Extra: gebruik TryParse om de input van de speler te verwerken, 
 *      zodat het programma niet zal crashen.
 */

/*
 * Deel 3
 * 
 * Declareer en initialiseer een aanvalswaarde voor de ridder, attackKnight (10), 
 * en de goblin, attackGoblin (5).
 * Laat de speler een actie selecteren door een getal in te geven. Gebruik een switch:
 *  - Als ik als speler actie 1 kies, dan val ik aan en wordt attackKnight afgetrokken van 
 *    goblinHealth. Beschrijf in de output wat er gebeurt.
 *  - Als ik als speler actie 2 kies, dan genees ik mezelf 10 levenspunten. Beschrijf in de 
 *    output wat er gebeurt.
 *  - Als de speler een ongeldige actie ingeeft, dan weergeef je dit in de output.
 *  - Extra: voeg extra acties toe die de speler kan kiezen.
 *  - Extra: zorg er voor dat de goblin ook een actie neemt.
 */

/*
 * Deel 4
 * 
 * Gebruik een for lus, zodat de speler exact 4 keer een actie kan selecteren.
 */

/*
 * Deel 5
 * 
 * Vervang de for lus door een while lus die vraagt aan de speler om een actie 
 * uit te voeren zolang als de ridder of goblin nog leeft.
 * 
 * Extra: zorg er voor dat de goblin ook een actie neemt.
 */
