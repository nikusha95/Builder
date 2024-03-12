namespace Builder.Person;

public class PersonJobBuilder(Person person) : PersonBuilder(person)
{
    public PersonJobBuilder At(string company)
    {
        Person.CompanyName = company;
        return this;
    }

    public PersonJobBuilder AsA(string position)
    {
        Person.Position = position;
        return this;
    }

    public PersonJobBuilder Earning(int income)
    {
        Person.AnnualIncome = income;
        return this;
    }
}