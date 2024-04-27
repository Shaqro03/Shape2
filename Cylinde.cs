namespace Shape2;

internal class Cylinder : Shape, Surface, Volume
{
    public void Glan()
    {
        do
        {
            if (r > 0 || h > 0)
            {
                Console.WriteLine($"S =  {s}");
                Console.WriteLine($"V =  {v}");

                break;
            }
            else
            {
                Console.WriteLine("Sxal e jish paymaner greq ");
                Sharavix();
                Bardzrutyun();
            }
        }
        while (true);
    }
    public void S()
    {
        s = 2 * Math.PI * r * (r + h);
    }
    public void V()
    {
        v = Math.PI * r * r * h;
    }

}
