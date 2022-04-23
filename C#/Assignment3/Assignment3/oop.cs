namespace Assignment3;

// Designing and Building Classes using object-oriented principles
public class Person
{
    public string Age { get; set; }
    private string address;
    public string Address
    { 
        get { return address;}
        private set { address = value; }
    }
    
    public string Phone { get; set; }
    public string Email { get; set; }

}
public class Student
{

}
public class Instructor
{
    public DateTime JoinDate { get; set; }

}
public class Course
{

}
public class Department
{

}