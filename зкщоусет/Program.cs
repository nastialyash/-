
public class Product : Money
{
    public int quantitu { get; set; }
    public string Name { get; set; }

    
   
        
    
    public Product(string cu, int c, int w) : base(cu, c, w)
    {

    }

    public int quantiti { get; set; }
    

}



public class Money
{
    public int Wholepart { get; set; }
    public int cents { get; set; }
    public string currency { get; set; }

    public Money(string cu, int c, int w)
    {
        currency = cu;
        Wholepart = w;
        cents = c;

    }
    public virtual void display()
    {
        Console.WriteLine($"Sum : {Wholepart}.{cents}{currency}");
    }

    public void add(int w, int c)
    {
        Wholepart += w;
        cents += c;
        if (c > 99)
        {
            Console.WriteLine("Error");
        }
    }
    public void subtract(int w, int c)
    {
        if (cents < c)
        {
            if (Wholepart > w)
            {
                Wholepart -= 1;
                cents += 100;

            }
            else
            {
                Console.WriteLine("Error");
                return;
            }
        }


        Wholepart -= w;
        cents -= c;
        if (Wholepart < 0)
        {
            Console.WriteLine("Error");
            Wholepart = 0;
            cents = 0;
        }

    }
}
public abstract class Worker {
    public string Name { get; private set; }

    protected Worker(string name)
    {
        Name = name;
    }
    public abstract void print();
}
public class President : Worker {

    public President(string name) : base(name) { }

    public override void print()
    {
        Console.WriteLine($"President is {Name}");
    }
}
public class Security : Worker
{
    public Security(string name) : base(name) { }

    public override void print()
    {
        Console.WriteLine($"Security is : {Name}");
    }
}
public class Manager : Worker {
    public Manager(string name) : base(name) {
    }
    public override void print()
    {
        Console.WriteLine($"Manager is : {Name}");
    }

    class Program {

        static void Main(string[] args)
        {
            Worker[] workers = new Worker[]
            {
                new President("Ivan Ivanov"),
                new Security("Vasil Petrov"),
                new Manager("Olya Kovakchuk")


            };
            foreach (Worker worker in workers)
            {
                worker.print();
            }
        }


    }
}
