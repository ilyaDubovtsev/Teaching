namespace ResharperExamples;

struct Point
{
    public double X;
}

class Program
{
    static void Main()
    {
        var ps = new Point[]
        {
            new Point { X = 3 },
        };
        var p = ps[0];
        Update(ps);
        var v = p.X + ps[0].X;

    }

    static void Update(Point[] ps)
    {
        ps[0].X++;
    }
}




