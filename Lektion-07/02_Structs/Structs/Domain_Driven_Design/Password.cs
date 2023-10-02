using System.Text.RegularExpressions;

namespace _02_Structs.Structs.Domain_Driven_Design;

public struct Password
{
    private readonly string value;

    public Password(string value)
        {
            if (!Regex.IsMatch(value, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.* [@$!%*?&])[A-Za-z\deS!%*?8]{8,}$"))
            throw new ArgumentException("Invalid password format");

            this.value = value;
        }
}