class Dormitory
{
    string name;
    string address;
    string phoneNum;
    List<Employee> employees = new List<Employee>();
    List<Student> students = new List<Student>();
    List<Director> directorlist = new List<Director>();
    List<AdminOffice> adminofficelist = new List<AdminOffice>();
    List<BedChanger> bedchangerlist = new List<BedChanger>();
    public Dormitory()
    {
        name = "Dorm 1";
        address = "Test street 55";
        phoneNum = "7384292734";
    }
    public String Name
    {
        get
        {
            return name;
        }
    }

    public String Address
    {
        get
        {
            return address;
        }
    }

    public String Phone
    {
        get
        {
            return phoneNum;
        }
    }
    public void hireEmployee(Human humans)
    {
        Random rnd = new Random();
        int randangka = rnd.Next(1, 3);
        if (randangka == 1)
        {
            double salary = rnd.Next(1, 1000) * 0.3;
            adminofficelist.Add(new AdminOffice(salary, humans.Name, humans.Phone, "Admin Office"));
        }
        else if (randangka == 2)
        {
            double salary = rnd.Next(1, 1000) * 0.4;
            bedchangerlist.Add(new BedChanger(salary, humans.Name, humans.Phone, "Bed Changer"));
        }
    }


    public List<Employee> Employees
    {
        get
        {
            return employees;
        }
    }
}