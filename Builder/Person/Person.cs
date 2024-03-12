namespace Builder.Person;

public class Person
{
    //address info
    public string? StreetAddress, PostCode, City;
    //employment info
    public string? CompanyName, Position;
    public int AnnualIncome;

    public override string ToString()
    {
        return $"Address:{City},{StreetAddress},{PostCode}\n{CompanyName},{Position},{AnnualIncome}";
    }
}