namespace CSharpStructs;

enum AccountType
{
    Manager,
    Cashier
}

struct User
{
    // Fields and Properties
    public string Name { get; set; }
    public string Username { get; set; }
    public AccountType UserAccountType { get; set; }

    // Constructor
    public User(string name, string username, AccountType userAccountType)
    {
        Name = name;
        Username = username;
        UserAccountType = userAccountType;
    }

    // Methods
    public void ChangeAccountType(AccountType newAccountType)
    {
        UserAccountType = newAccountType;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Username: {Username}, Account Type: {UserAccountType}";
    }
}

readonly struct Usery
{
    // Fields and Properties
    public string Name { get; }
    public string Username { get; }
    public AccountType UserAccountType { get; }

    // Constructor
    public Usery(string name, string username, AccountType userAccountType)
    {
        Name = name;
        Username = username;
        UserAccountType = userAccountType;
    }

    // Methods
    public override string ToString()
    {
        return $"Name: {Name}, Username: {Username}, Account Type: {UserAccountType}";
    }
}
