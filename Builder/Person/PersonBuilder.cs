namespace Builder.Person;

public class PersonBuilder
{
    protected Person Person;
    public PersonBuilder() => Person = new Person();

    protected PersonBuilder(Person person)
    {
        Person = person;
    }

    public PersonAddressBuilder Lives => new(Person);
    public PersonJobBuilder Works => new(Person);

    public static implicit operator Person(PersonBuilder pb)
    {
        return pb.Person;
    }
}