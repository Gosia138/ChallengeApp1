// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string name = "Ewa";
string gender = "female";
int age = 35;
if (name == "Ewa"&& age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
if(gender=="female")
{
    if (age<30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        Console.WriteLine("Kobieta powyżej 30 lat");
    }
}
if (gender != "female")
{
    if (age<18)
    {
        Console.WriteLine("Niepełnoletni Męczyzna");
    }
    else
    {
        Console.WriteLine("Pełnoletni Mężczyzna");
    }
}