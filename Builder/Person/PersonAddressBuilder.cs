namespace Builder.Person;

public class PersonAddressBuilder : PersonBuilder
{
    public PersonAddressBuilder(Person person) : base(person)
    {
        Person = person;
    }

    public PersonAddressBuilder At(string streetAddress)
    {
        Person.StreetAddress = streetAddress;
        return this;
    }

    public PersonAddressBuilder WithPostalCode(string postCode)
    {
        Person.PostCode = postCode;
        return this;
    }

    public PersonAddressBuilder In(string city)
    {
        Person.City = city;
        return this;
    }
}