// AddressBookSearch.cs
public class AddressBookSearch
{
    private List<AddressBook> addressBooks;

    public AddressBookSearch(List<AddressBook> addressBooks)
    {
        this.addressBooks = addressBooks;
    }

    public List<ContactPerson> SearchPersonByCity(string city)
    {
        List<ContactPerson> searchResult = new List<ContactPerson>();
        foreach (AddressBook addressBook in addressBooks)
        {
            List<ContactPerson> personsInCity = addressBook.Contacts.FindAll(p => p.City.Equals(city));
            searchResult.AddRange(personsInCity);
        }
        return searchResult;
    }

    public List<ContactPerson> SearchPersonByState(string state)
    {
        List<ContactPerson> searchResult = new List<ContactPerson>();
        foreach (AddressBook addressBook in addressBooks)
        {
            List<ContactPerson> personsInState = addressBook.Contacts.FindAll(p => p.State.Equals(state));
            searchResult.AddRange(personsInState);
        }
        return searchResult;
    }
}
