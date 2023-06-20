public class ContactPerson
{
    public string Name { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    // Other properties of a contact person

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        ContactPerson otherPerson = (ContactPerson)obj;
        return Name.Equals(otherPerson.Name);
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}
