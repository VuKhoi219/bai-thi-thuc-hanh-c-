namespace BaiTapThucHanh;

public class PeopleController
{
    private List<People> _peoples = new List<People>();

    public void InputAndDisplayValue()
    {
        Console.WriteLine("Simple Properties Demo");
        People people = new People();
        people.Name = "Marry";
        people.Gender = true;
        people.Age = 25;
        string gender;
        if (people.Gender)
        {
             gender = "Male";
        }
        else
        {
             gender = "female";
        }
        Console.WriteLine("Person details: Name = "+people.Name +", Gender = "+gender +", Age = " +people.Age);
        Console.WriteLine("Person details (apter incrementing age ): Name = "+people.Name +", Gender = "+gender +", Age = " +(people.Age+10));
    }
}