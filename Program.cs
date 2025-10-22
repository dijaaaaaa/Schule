//TEST TEST TEST  !!!WORSICHT MEIN CODE IST DOO DOO!!!

/* using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hallo 1ZA!");
string? text;  
text = string.Empty;
text = Console.ReadLine();
Console.WriteLine("text");
Console.WriteLine(text);


int age = 0;
Console.WriteLine("wie alt bist du");
age = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine(age + "?");


age = age + 5;
age += 5;

Console.WriteLine(age);  


//AUFGABE 1

Console.WriteLine("Wie heißt du?");    
string? name; // ? weil es optinal ist 
name = Console.ReadLine();
Console.WriteLine("Hallo " + name + "!");
Console.WriteLine("Wie alt bist du?");
int age1 = 0;
age1 = Convert.ToInt32(Console.ReadLine());
age1 = age1 + 30;
Console.WriteLine(name + " Du wirst " + age1 + " in 30 Jahre alt sein!"); 


//AUFGABE 2

using System.Runtime.CompilerServices;

Console.WriteLine("Hallo ich kann 2 Zahlen zusammen addieren!");
Console.WriteLine("Bitte geben Sie Zahl 1 an:");
int zahl1 = 0;
zahl1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bitte geben Sie Zahl 1 an:");
int zahl2 = 0;
zahl2 = Convert.ToInt32(Console.ReadLine());
int antwort = zahl1 + zahl2;
Console.WriteLine("Ihr Ergebniss ist " + antwort); 

//AUFGABE 3

Console.WriteLine("Hallo ich kann ihnen sagen ob Ihere Nummer durch 2 teilbar ist!");
Console.WriteLine("Bitte geben Sie Ihere Nummer an:");
int nummer = 0;
nummer = Convert.ToInt32(Console.ReadLine());
if (nummer % 2 == 0)
{
    Console.WriteLine("Ihre Nummer ist durch 2 teilbar");
}
else
{
    Console.WriteLine("Ihre Nummer ist NICHT durch 2 teilbar"); 
} 

//Console.WriteLine("Zahl ist {0}durch 2 teilbar", a % 2 == 0 ? "" : "nicht"); //aufgabe 3 in eine Zeile 


//Aufagebe 4

//0-9 Kleinkind
//10-20 Jugendlich 
//ab 20 Erwachsen 

byte a = 8;
if (a < 10)
{
    Console.WriteLine("Klein Kind");
}
else if ( a < 20)
{
    Console.WriteLine("Jugendlich");
}
else
{
    Console.WriteLine("Erwachsen");
}


//Aufgabe 5 

Console.WriteLine("Wie alt sind Sie?");
int alter = Convert.ToInt32(Console.ReadLine());
bool jung = alter <= 18;
bool alt = alter >= 18;
if (jung)
{
    Console.WriteLine("Sie sind zu jung!");
}
else if (alt)
{
    Console.WriteLine("Sie dürfen rein");
}

//AUFGABE 6 

Console.WriteLine("---FIZZBUZZ----");
Console.WriteLine("REGELN:");
Console.WriteLine("Wenn Ihere Nummer durch 3 teilbar ist sage ich FIZZ");
Console.WriteLine("Wenn es durch 5 teilbar ist sage ich BUZZ");
Console.WriteLine("Und wenn es durch beide Zahlen teilbar ist sage ich FIZZBUZZ");
Console.WriteLine("Bitte geben Sie Ihre Zahl ein");
int zahl = Convert.ToInt32(Console.ReadLine());

if (zahl % 3 == 0 && zahl % 5 == 0)
{
    Console.WriteLine("FIZZBUZZ");
}
else if (zahl % 3 == 0)
{
    Console.WriteLine("FIZZ");
}
else if (zahl % 5 == 0)
{
    Console.WriteLine("BUZZ");
}
else
{
    Console.WriteLine(zahl + " ist doo doo");
    Console.WriteLine("Probiere nochmal");
}

// AUFGABE 7 

Console.WriteLine("Hallo ich bin ein Tachenrechner!");
Console.WriteLine("Bitte geben Sie Zahl 1 an:");
int zahl1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bitte geben Sie Ihre gwünschten character");
string charr = Convert.ToString(Console.ReadLine());
Console.WriteLine("Bitte geben Sie Zahl 1 an:");
int zahl2 = Convert.ToInt32(Console.ReadLine());
if (charr == "+")
{
    Console.WriteLine("Ihr Ergebniss: ");
    Console.WriteLine(zahl1 + zahl2);
}
else if (charr == "-")
{
    Console.WriteLine("Ihr Ergebniss: ");
    Console.WriteLine(zahl1 - zahl2);
}
else if (charr == "*")
{
    Console.WriteLine("Ihr Ergebniss: ");
    Console.WriteLine(zahl1 * zahl2);
}
else if (charr == "/")
{
    Console.WriteLine("Ihr Ergebniss: ");
    Console.WriteLine(zahl1 / zahl2);
}
Console.ReadLine(); */


Console.WriteLine("Hallo ich bin ein Tachenrechner!");
Console.WriteLine("Bitte geben Sie Zahl 1 an:");
int zahl1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bitte geben Sie Ihre gwünschten character");
char charr = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Bitte geben Sie Zahl 1 an:");
int zahl2 = Convert.ToInt32(Console.ReadLine());

switch (charr)
{
   case '+': Console.WriteLine(zahl1 + zahl2); break;
    case '-': Console.WriteLine(zahl1 - zahl2); break;
    case '*': Console.WriteLine(zahl1 * zahl2); break;
    case '/': Console.WriteLine(zahl1 / zahl2); break;
}