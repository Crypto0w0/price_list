internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class MediumList
{
    List<InfoMedium> l;
    MediumList()
    {
        l = new List<InfoMedium>(0);
    }
    public void AddMedium(InfoMedium i)
    {
        l.Add(i);
    }
    public void DelMedium(string criteria)
    {
        for (int i = 0; i < l.Count; i++)
        {
            if (l[i].GetName() == criteria || l[i].GetManufacturer() == criteria || l[i].GetModel() == criteria)
            {
                l.Remove(l[i]);
            }
        }
    }
    public void Change(string n)
    {
        for (int i = 0; i < l.Count; i++)
        {
            if (l[i].GetName() == n)
            {
                Console.WriteLine("Write a new amount of Mediums");
                l[i].SetAmount(Convert.ToInt32(Console.ReadLine()));
            }
        }
    }
    public void Find(string n)
    {
        for (int i = 0; i < l.Count; i++)
        {
            if (l[i].GetName() == n)
            {
                l[i].Print();
            }
        }
    }
}

class InfoMedium
{
    protected string name;
    protected string manufacturer;
    protected string model;
    protected int amount;
    protected int price;
    public InfoMedium()
    {
        name = "";
        manufacturer = "";
        model = "";
        amount = 0;
        price = 0;
    }
    public string GetName()
    {
        return name;
    }
    public string GetManufacturer()
    {
        return manufacturer;
    }
    public string GetModel()
    {
        return model;
    }
    public int GetAmount()
    {
        return amount;
    }
    public void SetAmount(int n)
    {
        amount = n;
    }
    public int GetPrice()
    {
        return price;
    }
    public void Print()
    {
        Console.WriteLine(name);
        Console.WriteLine(manufacturer);
        Console.WriteLine(model);
        Console.WriteLine(amount);
        Console.WriteLine(price);
    }
}

class Flash : InfoMedium
{
    int volume;
    int speed;
    public Flash()
    {
        volume = 0;
        speed = 0;
    }
    public Flash(Flash f)
    {
        this.name = f.name;
        this.manufacturer = f.manufacturer;
        this.model = f.model;
        this.amount = f.amount;
        this.price = f.price;
        this.volume = f.volume;
        this.speed = f.speed;
    }
    public void Print()
    {
        Console.WriteLine(name);
        Console.WriteLine(manufacturer);
        Console.WriteLine(model);
        Console.WriteLine(amount);
        Console.WriteLine(price);
        Console.WriteLine(volume);
        Console.WriteLine(speed);
    }

}

class DVD : InfoMedium
{
    int size;
    int speed;
    public DVD()
    {
        size = 0;
        speed = 0;
    }
    public DVD(DVD d)
    {
        this.name = d.name;
        this.manufacturer = d.manufacturer;
        this.model = d.model;
        this.amount = d.amount;
        this.price = d.price;
        this.size = d.size;
        this.speed = d.speed;
    }
    public void Print()
    {
        Console.WriteLine(name);
        Console.WriteLine(manufacturer);
        Console.WriteLine(model);
        Console.WriteLine(amount);
        Console.WriteLine(price);
        Console.WriteLine(size);
        Console.WriteLine(speed);
    }
}

class HDD : InfoMedium
{
    int readSpeed;
    int writeSpeed;
    public HDD()
    {
        readSpeed = 0;
        writeSpeed = 0;
    }
    public HDD(HDD h)
    {
        this.name = h.name;
        this.manufacturer = h.manufacturer;
        this.model = h.model;
        this.amount = h.amount;
        this.price = h.price;
        this.readSpeed = h.readSpeed;
        this.writeSpeed = h.writeSpeed;
    }
    public void Print()
    {
        Console.WriteLine(name);
        Console.WriteLine(manufacturer);
        Console.WriteLine(model);
        Console.WriteLine(amount);
        Console.WriteLine(price);
        Console.WriteLine(readSpeed);
        Console.WriteLine(writeSpeed);
    }
}