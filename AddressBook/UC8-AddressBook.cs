public class ViewPersonsByCityStateUC
{
    public static Dictionary<string, List<ContactPerson>> ViewPersonsByCity(List<AddressBook> addressBooks)
    {
        Dictionary<string, List<ContactPerson>> personsByCity = new Dictionary<string, List<ContactPerson>>();
        foreach (AddressBook addressBook in addressBooks)
        {
            foreach (ContactPerson person in addressBook.Contacts)
            {
                if (!personsByCity.ContainsKey(person.City))
                    personsByCity.Add(person.City, new List<ContactPerson>());

                personsByCity[person.City].Add(person);
            }
        }
        return personsByCity;
    }

    public static Dictionary<string, List<ContactPerson>> ViewPersonsByState(List<AddressBook> addressBooks)
    {
        Dictionary<string, List<ContactPerson>> personsByState = new Dictionary<string, List<ContactPerson>>();
        foreach (AddressBook addressBook in addressBooks)
        {
            foreach (ContactPerson person in addressBook.Contacts)
            {
                if (!personsByState.ContainsKey(person.State))
                    personsByState.Add(person.State, new List<ContactPerson>());

                personsByState[person.State].Add(person);
            }
        }
        return personsByState;
    }
}
