public class AddressBook
{
    public string Name { get; set; }
    public List<ContactPerson> Contacts { get; set; }

    public AddressBook(string name)
    {
        Name = name;
        Contacts = new List<ContactPerson>();
    }

    public void AddContact(ContactPerson person)
    {
        if (!Contacts.Contains(person))
            Contacts.Add(person);
    }

    public void EditContact(string name, ContactPerson updatedPerson)
    {
        ContactPerson existingPerson = Contacts.Find(p => p.Name.Equals(name));
        if (existingPerson != null)
        {
            existingPerson.Name = updatedPerson.Name;
            existingPerson.City = updatedPerson.City;
            existingPerson.State = updatedPerson.State;
            // Update other properties as needed
        }
    }

    public void DeleteContact(string name)
    {
        ContactPerson personToRemove = Contacts.Find(p => p.Name.Equals(name));
        if (personToRemove != null)
            Contacts.Remove(personToRemove);
    }
}