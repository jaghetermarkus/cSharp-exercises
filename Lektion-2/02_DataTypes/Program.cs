/* 

 C# standard datatyper som används
-----------------------------------
* string      till för text               string name = "Markus";

* int         till för heltal             int age = 34;
- long        till för heltal             long age = 39;

* decimal     till för decimaltal         decimal length = 188.5m;
- double      till för decimaltal         double length = 188.5;
- float       till för decimaltal         float length = 188.5f;

* bool        till för sant/falsk         bool isHuman = true;

- char        till för enskilt tecken     char gender = 'M';

- dynamic     kan innehålla vad som       dynamic lastName = "Karlsson";
                                          dynamic weight = 95.0;

* Guid        globalt unikt id            Guid id = Guid.NewGuid();
- byte        ---
* null        ---
- object      ---

* = vanligaste variablerna

*/

/*
string name = "Markus";

int age = 34;
long age = 39;

decimal length = 188.5;
double length = 188.5;
float length = 188.5f;

bool isHuman = true;

char gender = 'M';

dynamic lastName = "Karlsson";
dynamic weight = 95.0;

Guid id = Guid.NewGuid();
*/

/*

Deklarera variabler i C#
---------------------------------
camelCase       firstName       string firstName = "Markus";
Pascal          FirstName       string FirstName = "Markus";
kebab-case      first-name      string first-name = "Markus";
snake_case      first_name      string first_name = "Markus";

C# använder sig primärt av Pascal men även camelCase
camelCase oftast till variabler

Korrekt sätt att deklarera:     string firstName = "Markus";
Latmanssättet att deklarera:    var firstName = "Markus";

var firstName = "Markus";
*/



/*

STRING - textbaserade värden
----------------------------------

string firstName = "Markus";
var lastName = "Karlsson";



string firstName = "Markus";
var lastName = "Karlsson";

string sentence2 = "Jag heter Markus och är \"bäst\".";

string url = "c:\\education\\cms23-cSharp";
string url = @"c:\education\cms23-cSharp";

//  Backslash ( \ ) läser kommande tecken som text.
//  @ bortser från funktionen som backslash har, ex. i en url.

string placeholder_1 = "Hej jag heter " + firstName + " " + lastName + ".";
string placeholder_2 = $"Hej jag heter {firstName} {lastName}.";
string placeholder_3 = string.Format("Hej jag heter {0} {1}.", firstName, lastName);

// Vanligast att använda funktionen ovan (placeholder_2) med $ samt {} för att slå ihop text med variabler

*/


Console.Write("Skriv ditt förnamn: ");
string firstName = Console.ReadLine() ?? "";

Console.Write("Skriv ditt efternamn: ");
string lastName = Console.ReadLine() ?? string.Empty;

Console.WriteLine($"Hej {firstName} {lastName}!");
Console.ReadKey();

/*

TILL NÄSTA GÅNG

Öva på datatyperna

Youtube eller ChatGPT

*/

