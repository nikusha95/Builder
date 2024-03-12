namespace Builder.Classes;

public class PersonBuilder
{
    protected Person _person;
    public PersonBuilder() => new Person();

    protected PersonBuilder(Person person)
    {
        _person = person;
    }

    public PersonAddressBuilder Lives => new(_person);
    public PersonJobBuilder Works => new(_person);

    public static implicit operator Person(PersonBuilder pb)
    {
        return pb._person;
    }
}