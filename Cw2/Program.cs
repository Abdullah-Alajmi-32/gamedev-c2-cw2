string HeroName = "Crash";
int HeroAge = 16;
int HeroHight = 10;
string Superpower1 = "Fly";
string Superpower2 = "Jump High";
Console.WriteLine("My name is {0} and My age is {1} and my hieght is {2} and my superpower is {3} and my other superpower is {4}", HeroName, HeroAge, HeroHight, Superpower1,Superpower2);

string HeroName2 = "Nate";
int HeroAge2 = 18;
int HeroHight2 = 15;
string Superpower3 = "Fire";
String superpower4 = "invisible ";
Console.WriteLine("My name is {0} and My age is {1} and my hieght is {2} and my super power is {3} and my other super power is {4}", HeroName2, HeroAge2, HeroHight2, Superpower3, superpower4);

int ageDifference = HeroAge2 - HeroAge;
Console.WriteLine("Nate is older than Crash By {0}", ageDifference);

Console.WriteLine(HeroHight < HeroHight2);

int Crashpower = 100;
int Natepower = 200;

if (Natepower > Crashpower)
{
    Console.WriteLine("Nate is more powerful");
}
else if (Crashpower > Natepower)
{
    Console.WriteLine("Carsh is more powerful");
}
else
{
    Console.WriteLine("Neither is more powerful");
}