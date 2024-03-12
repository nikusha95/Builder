namespace Builder.Person;

public class PersonJobBuilder(Person person) : PersonBuilder(person)
{
    public PersonJobBuilder At(string company)
    {
        _person.CompanyName = company;
        return this;
    }

    public PersonJobBuilder AsA(string position)
    {
        _person.Position = position;
        return this;
    }

    public PersonJobBuilder Earning(int income)
    {
        _person.AnnualIncome = income;
        return this;
    }
}