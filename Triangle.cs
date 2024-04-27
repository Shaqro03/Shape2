namespace Shape2;

internal class Triangle : Shape, Perimeter, Surface
{
    public void Erankyun()
    {
        do
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {

                Console.WriteLine($"p = {p}");



                Console.WriteLine($"S =  {s}");
                break;
            }
            else
            {
                Console.WriteLine("Sxal koxmer en nermucavc");
                Koxm1();
                Koxm2();
                Koxm3();

            }
        }
        while (true);

    }
    public void P()
    {
        p = a + b + c;
    }
    public void S()
    {
        s = Math.Sqrt((((a + b + c) / 2) * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c)));
    }
}

