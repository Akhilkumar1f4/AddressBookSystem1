// AddressBookSystem.cs
public class AddressBookSystem
{
    public Dictionary<string, AddressBook> AddressBooks { get; set; }

    public AddressBookSystem()
    {
        AddressBooks = new Dictionary<string, AddressBook>();
    }

    public void AddAddressBook(string name)
    {
        AddressBook newAddressBook = new AddressBook(name);
        AddressBooks.Add(name, newAddressBook);
    }
}

