public class AddMultipleContactsUC
{
    public static void AddMultipleContacts(AddressBook addressBook, List<ContactPerson> persons)
    {
        foreach (ContactPerson person in persons)
        {
            addressBook.AddContact(person);
        }
    }
}