

abstract class Rooms
{
    Guid roomid;
    public Rooms()
    {
        roomid = Guid.NewGuid();
    }
    public abstract void StudentLive(Student student);


}

class SmallRoom : Rooms
{

    double price;
    public SmallRoom(double price, int max, Student student)
    {
        this.price = price;
        max = 3;
    }

    public override void StudentLive(Student student)
    {
        Console.WriteLine($"Welcome {student.Name} to SmallRoom");
    }

    public double pricesmallroom
    {
        get
        {
            return price;
        }
    }


}

class BigRooms : Rooms
{

    double price;
    public BigRooms(double price, int max, Student student)
    {
        this.price = price;
        max = 4;
    }

    public override void StudentLive(Student student)
    {
        Console.WriteLine($"Welcome {student.Name} to BigRooms");
    }

    public double pricebigroom
    {
        get
        {
            return price;
        }
    }
}