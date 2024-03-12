namespace Builder.Classes;

public class PersonAddressBuilder : PersonBuilder
{
    public PersonAddressBuilder(Person person) : base(person)
    {
        _person = person;
    }

    public PersonAddressBuilder At(string streetAddress)
    {
        _person.StreetAddress = streetAddress;
        return this;
    }

    public PersonAddressBuilder WithPostalCode(string postCode)
    {
        _person.PostCode = postCode;
        return this;
    }

    public PersonAddressBuilder In(string city)
    {
        _person.City = city;
        return this;
    }
}