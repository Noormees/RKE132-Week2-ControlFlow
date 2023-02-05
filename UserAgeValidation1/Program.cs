// rakendus küsib kasuutajal sisestada tema vanuse
// kui kasutaja vanus väiksem, kui 13, siis konsoolis kuvatakse:
// "You are too young to use Instagram"
// muul juhul kuvatakse:
// "Welcome to Instagram!"

Console.WriteLine("Please enter your age:"); // string - "13" - HEAP; char/int - 13 - STACK

int UserAge = Int32.Parse(Console.ReadLine());

if (UserAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else
{
    Console.WriteLine("You are too young to use Instagram.");
}


