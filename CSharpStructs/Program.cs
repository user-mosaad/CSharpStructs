namespace CSharpStructs;

class Program
{
    static void Main()
    {
        User user1 = new("John Doe", "john", AccountType.Cashier);
        Usery usery1 = new Usery("Michael", "michael", AccountType.Manager);
        Console.WriteLine(user1);
        Console.WriteLine(usery1);
    }
}
