// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
string name = "Ewa";
string gender = "female";
int age = 33;
if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
else if(age<30 && gender=="female")

    {
        Console.WriteLine("Kobieta poniżej 30 lat");

    }
else if (age==30 && gender=="female")
{
    Console.WriteLine("Kobieta lat 30");
}
else if (age>30 && gender=="female")
    {
        Console.WriteLine("Kobieta powyżej 30 lat");
    }

else if (age<18 && gender != "female")

    {
        Console.WriteLine("Niepełnoletni Męczyzna");
    }
else
    {
        Console.WriteLine("Pełnoletni Mężczyzna");
    }
