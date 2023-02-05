// See https://aka.ms/new-console-template for more information


//rakendus kysib kasutajalt valida tema sugu (M/F)
//rakendus kysib kasutajalt sisestada oma perekonnanime
//vastavalt sisestatud andmetele, rakendus tervitab kasutajat:
//"Welcome Mr. [kasutaja perekonnanimi]" / "Welcome Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (M/F):");

char userGender = Char.Parse(Console.ReadLine()); // loeb ainult "string" tähendust

Console.WriteLine("Please enter your last name:");

string UserName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {UserName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {UserName}!");
}
else
{
    Console.WriteLine($"Welcome, {UserName}");
}