// AddressBookCount.cs
public class AddressBookCount
{
    private List<AddressBook> addressBooks;

    public AddressBookCount(List<AddressBook> addressBooks)
    {
        this.addressBooks = addressBooks;
    }

    public int GetPersonCountByCity(string city)
    {
        int count = 0;
        foreach (AddressBook addressBook in addressBooks)
        {
            count += addressBook.Contacts.Count(p => p.City.Equals(city));
        }
        return count;
    }

    public int GetPersonCountByState(string state)
    {
        int count = 0;
        foreach (AddressBook addressBook in addressBooks)
        {
            count += addressBook.Contacts.Count(p => p.State.Equals(state));
        }
        return count;
    }
}