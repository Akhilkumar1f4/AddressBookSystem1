public class SearchPersonAcrossAddressBooksUC
{
    public static List<ContactPerson> SearchPersonByCityState(List<AddressBook> addressBooks, string city, string state)
    {
        List<ContactPerson> searchResult = new List<ContactPerson>();
        foreach (AddressBook addressBook in addressBooks)
        {
            List<ContactPerson> personsInCity = addressBook.Contacts.FindAll(p => p.City.Equals(city) && p.State.Equals(state));
            searchResult.AddRange(personsInCity);
        }
        return searchResult;
    }
}