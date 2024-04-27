namespace Shape2;

internal class Sphere : Shape, Volume, Surface
{
    public void Gund()
    {
        do
        {
            if (r > 0)
            {
                Console.WriteLine($"S =  {s}");
                Console.WriteLine($"V =  {v}");

                break;
            }

            else
            {
                Console.WriteLine("Sxal R e");
                Sharavix();
            }
        }
        while (true);
    }
    public void V()
    {
        v = (4 * Math.PI * r * r * r) / 3;
    }
    public void S()
    {
        s = 4 * Math.PI * r * r;
    }
}

