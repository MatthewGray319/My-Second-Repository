// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var isSunny = true;
var isRaining = false;
if (isSunny) 
{
    Console.WriteLine("It is sunny!");
}
int a = 0;
a += 5;
int b = 0;
b -= 5;
int c = 0;
c *= 4;
int d = 0;
d /= 2;
int e = 5;
e %= 2;

Console.WriteLine(a);
b = ++a;
Console.WriteLine(a);
Console.WriteLine(b);
c = a++;
Console.WriteLine(a);
Console.WriteLine(c);


int score = 450;
int pointsNeededToPass = 100;

bool levelComplete;

if (score >= pointsNeededToPass)
    levelComplete = true;
else
    levelComplete = false;
if (levelComplete)
    Console.WriteLine("You've beaten this level!");


