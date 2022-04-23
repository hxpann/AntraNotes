namespace Assignment3;

// Designing and Building Classes using object-oriented principles
public class Person
{
    //private instance variables
    private string name, address;

    //Constructs a Person instance with the given name and address
    public Person(String name, String address)
    {
        this.name = name;
        this.address = address;
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