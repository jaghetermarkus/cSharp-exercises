/*

IF STATEMENT (Operander)
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

*/


string firstName = "Markus";
string lastName = "";

if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
{
    Console.WriteLine("Något utan värdena är inte ifyllda.");
}

Console.ReadKey();


