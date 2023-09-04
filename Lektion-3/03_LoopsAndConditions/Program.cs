

/*  IF STATEMENT (Operander)
------------------------------------------------------------------------
==          lika med
!=          inte lika med
<           mindre än
<=          mindre eller lika med
>           större än
>=          större eller lika med
&&          och
||          eller           (mac: opt + 7)
!           om det inte är det här
??          om första värdet är null -> välj det andra


**** OLIKA SÄTT ATT SKRIVA IF-SATSER PÅ ****
1.  if (true) {}

2.  if (true) {} else {}

3a. if (true) {} else if (true) {} else {}

3b. if (true) {} else if (true) {} else if (true) {} else if (true) {} else {}

4.  (true) ? do_this : do_this;


string name = "Markus";
string firstName = "Vidar";

if (name == firstName)
{
    Console.WriteLine("Namnen är lika.");
}
else
{
    Console.WriteLine("Namnen är inte lika.");
}


string firstName = "";

if (!string.IsNullOrEmpty(firstName))
{
    Console.WriteLine("Nu gör vi någonting med förnamnet");
}
else
{
    Console.WriteLine("Det finns inget förnamn");
}



string firstName = "Markus";
string lastName = "";

if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
{
    Console.WriteLine("Något utan värdena är inte ifyllda.");
}


string key = "black";

switch (key)
{
    case "blue":
        Console.WriteLine("Unlock blue door");
        break;

    case "orange":
        Console.WriteLine("Unlock orange door");
        break;

    case "gray":
        Console.WriteLine("Unlock gray door");
        break;

    default:
        Console.WriteLine("Unlock blue door");
        break;
}

// Switch är effektivare än if då den inte testar varje alternativ i ordning uppifrån och ned. Den ser vilket det rätta värdet är och går direkt dit och annars till default om ingen matchning finns
// Kan endast använda == tester. Inte &&, !, < osv...
// Switch är bra vid ex. meny/flikalternativ i ett program.




*/

/*LOOP
------------------------------------------------------------------
for             gör något ett givet antal gånger
foreach         gör något för varje värde/ objekt i en lista/array
while           om ett tillstånd är sant gör något tills det inte är sant
do-while        gör något minst en gång och gör det sedan igen tills tillståndet inte är sant


*/

/*FOR-LOOP
----------------------------------------------------
gör något ett givet antal gånger

// for (initialize value; condition; increment inizialized value)
{
}


for (int i = 0; i < 10; i++) 
{
    Console.WriteLine("loop nr: " + i);
}


*/

/*FOREACH-LOOP
----------------------------------------------------
gör något för varje värde/ objekt i en lista/array

//Array - Det går inte lägga till/ta bort värdet i en array. Det går att ändra i befintliga fält däremot. 

string[] names = new string[] {"Markus", "Jessica", "Vidar", "Vilgot"};

names[0] = "Johan";

foreach (var name in names)
{
    Console.WriteLine(name);
}


// Alternativ för for-loop, men ej att föredra. 
//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names[i]);
//}

*/

/*ARRAYS
----------------------------------------------------

En array är

????????????????????????

*/

/*WHILE
----------------------------------------------------
Gör om en sak om och om igen tills en sak är uppnått.
Varav kontroller sker i början

using System;

var number = 0;

while (number < 100)
{
    Console.WriteLine("Number är " + number);
    number++;
}

*/

/*DO WHILE
----------------------------------------------------
Gör loopen minst en gång sedan kollar den tillståndet
//Bra alternativ för att skriva ut menyerna i terminalen

var index = 1;

do
{
    Console.WriteLine("Index är " + index);
    index++;
}
while (index < 1);




Console.ReadKey();

*/