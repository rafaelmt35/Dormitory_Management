public class Human
{
    string name;

    string phone;


    public Human(string name, string phone)
    {
        this.name = name;
        this.phone = phone;

    }
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public string Phone
    {
        get
        {
            return phone;
        }
        set
        {
            phone = value;
        }
    }
}

public abstract class Employee : Human
{
    Guid empid;
    double salary;
    string dateJoined;

    string roles;
    public Employee(double salary, string name, string phone, string roles) : base(name, phone)
    {
        empid = Guid.NewGuid();
        this.salary = salary;
        this.dateJoined = DateTime.Now.ToString("dd.MM.yy");
        this.roles = roles;
        // Console.WriteLine(roles);
    }

    public string DateJoined
    {
        get
        {
            return dateJoined;
        }
    }

    public double Salary
    {
        get
        {
            return salary;
        }
    }

    public abstract bool resign();

}

class Director : Employee
{


    public Director(double salary, string name, string phone, string roles) : base(salary, name, phone, roles)
    {

    }

    public override bool resign()
    {
        return true;
    }

    public void givestudRoom(Student student)
    {
        Random rnd = new Random();
        if (rnd.Next(1, 20) % 2 == 0)
        {

        }
        else
        {

        };

    }


}

class AdminOffice : Employee
{
    public AdminOffice(double salary, string name, string phone, string roles) : base(salary, name, phone, roles)
    {

    }
    public override bool resign()
    {
        return true;
    }

    public Student registernewStud(Human human)
    {
        Student newStudent = new Student(human.Name, human.Phone);
        return newStudent;
    }


}

class BedChanger : Employee
{
    public BedChanger(double salary, string name, string phone, string roles) : base(salary, name, phone, roles)
    {

    }
    public override bool resign()
    {
        return true;
    }

    public void changeBedLinen()
    {
        Console.WriteLine("CHANGED!");
    }
}

class Student : Human
{
    Guid studid;
    bool hasWifi;
    public Student(string name, string phone) : base(name, phone)
    {
        studid = Guid.NewGuid();
        this.hasWifi = false;
    }

    public string StudName
    {
        get
        {
            return this.Name;
        }
    }

    public bool buyWifi()
    {
        return false;
    }

    public void registerRoom(Director director)
    {
        director.givestudRoom(this);
    }
}