public class DuplicateCheckUC
{
    public static bool IsDuplicateContact(AddressBook addressBook, ContactPerson person)
    {
        return addressBook.Contacts.Contains(person);
    }
}
