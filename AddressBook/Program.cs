public class Program
{
    public static void Main()
    {
        AddressBookSystem system = new AddressBookSystem();
        AddressBook addressBook = new AddressBook("Address Book 1");
        ContactPerson person1 = new ContactPerson { Name = "John Doe", City = "New York", State = "New York State" };
        ContactPerson person2 = new ContactPerson { Name = "Jane Smith", City = "Los Angeles", State = "California" };

        // UC1 - Adding a new contact
        AddContactUC.AddContact(addressBook, person1);

        // UC2 - Editing an existing contact
        EditContactUC.EditContact(addressBook, "John Doe", new ContactPerson { Name = "John Doe", City = "Chicago", State = "Illinois" });

        // UC3 - Deleting a contact
        DeleteContactUC.DeleteContact(addressBook, "John Doe");

        // UC4 - Adding multiple contacts
        List<ContactPerson> persons = new List<ContactPerson> { person1, person2 };
        AddMultipleContactsUC.AddMultipleContacts(addressBook, persons);

        // UC5 - Adding a new address book
        AddAddressBookUC.AddAddressBook(system, "Address Book 2");

        // UC6 - Checking for duplicate contacts
        bool isDuplicate = DuplicateCheckUC.IsDuplicateContact(addressBook, person1);

        // UC7 - Searching persons by city/state across address books
        AddressBookSearch search = new AddressBookSearch(system.AddressBooks.Values.ToList());
        List<ContactPerson> personsInCity = search.SearchPersonByCity("New York");
        List<ContactPerson> personsInState = search.SearchPersonByState("New York State");

        // UC8 - Viewing persons by city/state
        Dictionary<string, List<ContactPerson>> personsByCity = ViewPersonsByCityStateUC.ViewPersonsByCity(system.AddressBooks.Values.ToList());
        Dictionary<string, List<ContactPerson>> personsByState = ViewPersonsByCityStateUC.ViewPersonsByState(system.AddressBooks.Values.ToList());

        // UC9 - Getting the count of persons by city/state
        AddressBookCount count = new AddressBookCount(system.AddressBooks.Values.ToList());
        int countByCity = count.GetPersonCountByCity("New York");
        int countByState = count.GetPersonCountByState("New York State");

        // UC10 - Getting the count of contact persons by city and state
        int countByCityUC10 = GetPersonCountByCityStateUC.GetPersonCountByCity(system.AddressBooks.Values.ToList(), "New York");
        int countByStateUC10 = GetPersonCountByCityStateUC.GetPersonCountByState(system.AddressBooks.Values.ToList(), "New York State");

        // Output
        Console.WriteLine("UC1 - Added a new contact:");
        Console.WriteLine(person1);

        Console.WriteLine("\nUC2 - Edited an existing contact:");
        Console.WriteLine(person1);

        Console.WriteLine("\nUC3 - Deleted a contact.");

        Console.WriteLine("\nUC4 - Added multiple contacts.");
        foreach (var contact in persons)
        {
            Console.WriteLine(contact);
        }

        Console.WriteLine("\nUC5 - Added a new address book:");
        Console.WriteLine(system.AddressBooks["Address Book 2"]);

        Console.WriteLine("\nUC6 - Checked for duplicate contacts:");
        Console.WriteLine("Is Duplicate: " + isDuplicate);

        Console.WriteLine("\nUC7 - Searched persons by city (New York):");
        foreach (var person in personsInCity)
        {
            Console.WriteLine(person);
        }

        Console.WriteLine("\nUC7 - Searched persons by state (New York State):");
        foreach (var person in personsInState)
        {
            Console.WriteLine(person);
        }

        Console.WriteLine("\nUC8 - Viewed persons by city:");
        foreach (var entry in personsByCity)
        {
            Console.WriteLine("City: " + entry.Key);
            foreach (var person in entry.Value)
            {
                Console.WriteLine(person);
            }
        }

        Console.WriteLine("\nUC8 - Viewed persons by state:");
        foreach (var entry in personsByState)
        {
            Console.WriteLine("State: " + entry.Key);
            foreach (var person in entry.Value)
            {
                Console.WriteLine(person);
            }
        }

        Console.WriteLine("\nUC9 - Got the count of persons by city (New York):");
        Console.WriteLine("Count: " + countByCity);

        Console.WriteLine("\nUC9 - Got the count of persons by state (New York State):");
        Console.WriteLine("Count: " + countByState);

        Console.WriteLine("\nUC10 - Got the count of contact persons by city (New York):");
        Console.WriteLine("Count: " + countByCityUC10);

        Console.WriteLine("\nUC10 - Got the count of contact persons by state (New York State):");
        Console.WriteLine("Count: " + countByStateUC10);
    }
}