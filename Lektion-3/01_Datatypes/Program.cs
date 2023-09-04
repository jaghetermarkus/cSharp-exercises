/*

STRING ----- TILL FÖR TEXT
--------------------------

string firstName = "Markus";
var lastName = "Karlsson";

string sentence = "Jag är \"bäst\" i hela världen";
string uri = "c:\\users\\Markus\\documents";
string uri2 = @"c:\users\Markus\documents";

\ = läs nästa tecken som text, inte som något om det har annan funktion, ex. "

string placeholder_1 = "Hej jag heter " + firstName + " " + lastName + ".";
string placeholder_2 = $"Hej jag heter {firstName} {lastName}.";
string placeholder_3 = string.Format("Hej jag heter {0) {1}.", firstName, lastName);

string email = " Markus@mail.com";
Console.WriteLine($"Original: {email}");

Console.WriteLine($"ToUpper: {email.ToUpper()}");

Console.WriteLine($"ToLower: {email.ToLower()}");

string firstName = " Markus ";
string lastName = " Karlsson";

Console.WriteLine($"{firstName} {lastName}");
Console.WriteLine($"{firstName.Trim()} {lastName.Trim()}");

string sentence = "Här har vi en text som är på svenska.";
Console.WriteLine(sentence.Replace("ä", "a"));

// !!!!!! KOLLA UPP "REGULAR EXPRESSIONS" FÖR ETT SMIDIGARE SÄTT !!!!!!

string name = "Markus Karlsson";
string domain = "domain.com";
string emailaddress = $"{name}@{domain}";
Console.WriteLine(emailaddress);

emailaddress = emailaddress.Replace(" ", ".").ToLower();
Console.WriteLine(emailaddress);

Console.ReadKey();

 */

/*

INTERGRALS & FLOATING POINTS
------------------------------------

Type            Bits        RANGE (min, max)
------------------------------------------------
*   byte        8           0                           255
    sbyte       8           -128                        127           
    short       16          -32768                      32767
    ushort      16          0                           655535
*   int         32          - 2 147 483 648             2 147 483 647
    uint        32          0                           4 294 967 295
*   long        64          -92233722036854775808       9223372036854775807
    ulong       64          0                           18446744073709551615

* = viktigast

    Type        Byte        DECIMAL RANGE       SUFFIX    
--------------------------------------------------------
    float       4           6-9 digits          f eller F 
    double      8           15-16 digits        inget eller d eller D
*   decimal     16          28-29 digits        m eller M



float floatValue = 0.1f + 0.1f + 0.1f;          //0.3
Console.WriteLine("Float: " + floatValue);
// float = 1.123456789f;

double doubleValue = 0.1 + 0.1 + 0.1d;          //0.30000000000000004
Console.WriteLine("Double: " + doubleValue);
// double = 1.12345678912345;

decimal decimalValue = 0.1m + 0.1m + 0.1m;      //0.3
Console.WriteLine("Decimal: " + decimalValue);
// decimal = 1.1234567890123456789012345678m

// **** Decimal är att föredra!!! ****




BOOL (BOOLEAN)          Bits
--------------------------------------------------------------
bool                    0 / 1               false / true

bool isEnable = false;
bool isActive = true;




GUID / UUID (Globally Unique Identifier)
---------------------------------------------------------
Guid    16 bytes    Guid.NewGuid();     8428f0a1-129e-4c57-a5aa-461bfd15da84

Guid userId = Guid.NewGuid();
Console.WriteLine(userId);


 */

Console.ReadKey();
