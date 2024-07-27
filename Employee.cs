public class Employee
{
    public string firstName { get; private set; }
    public string lastName { get; private set; }
    public Date birthDate { get; private set; }
    public Date hireDate { get; private set; }

    // constructor to initialize name, birth date and hire date
    public Employee(string first, string last, Date dateOfBirth, Date dateOfHire)
    {
        firstName = first;
        lastName = last;
        birthDate = dateOfBirth;
        hireDate = dateOfHire;
    }

    // convert Employee to string format
    public override string ToString()
    {
        return string.Format($"{lastName}, {firstName} Hired: {hireDate} Birthday: {birthDate}");
    }
}