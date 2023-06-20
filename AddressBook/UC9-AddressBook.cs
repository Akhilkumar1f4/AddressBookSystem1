public class GetPersonCountByCityStateUC
{
    public static int GetPersonCountByCity(List<AddressBook> addressBooks, string city)
    {
        int count = 0;
        foreach (AddressBook addressBook in addressBooks)
        {
            count += addressBook.Contacts.Count(p => p.City.Equals(city));
        }
        return count;
    }

    public static int GetPersonCountByState(List<AddressBook> addressBooks, string state)
    {
        int count = 0;
        foreach (AddressBook addressBook in addressBooks)
        {
            count += addressBook.Contacts.Count(p => p.State.Equals(state));
        }
        return count;
    }
}