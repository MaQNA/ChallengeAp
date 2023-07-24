/// ZADANIE DOMOWE (DZIEŃ 4)

string name = "Zosia";
char sex = 'F';
int age = 28;

if (sex == 'F' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == 'M' && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}



bool textIsOK = true;

if (textIsOK == true)
{
    Console.WriteLine("MAM TĘ MOC");
}

else if (textIsOK == false)
{
    Console.WriteLine("MOCY BRAK");
}