using System.Runtime.InteropServices;

namespace _02_Structs.Structs.Interoperability;

[StructLayout(LayoutKind.Sequential)] // Attiribut, säger att den har samma struktur som kodspråket 'C'

public struct Todo
{
    public int UserId;
    public int Id;
    public string Title;
    public bool Completed;
}

/*

    https://jsonplaceholder.typicode.com/

    {
      "userId": 1,
      "id": 1,
      "title": "delectus aut autem",
      "completed": false
    }

 */
