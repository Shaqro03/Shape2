namespace Shape2;

internal class Rectangle : Shape, Perimeter, Surface
{



    public void Uxankyun()
    //  |--------------|
    // a |              | d
    //  |              | 
    //  |______________|
    //        b
    {
        do
        {
            if ((a == d) && (c == b))
            {


                Console.WriteLine($"P = {p}");

                Console.WriteLine($"S = {s}");
                break;
            }
            else
            {
                Console.WriteLine("Sxal koxmer en nermucvac jisht koxmer greq");
                Koxm1();
                Koxm2();
                Koxm3();
                Koxm4();

            }
        }
        while (true);
    }
    public void P()
    {
        p = a + b + c + d;
    }
    public void S()
    {
        s = a * b;
    }

}
