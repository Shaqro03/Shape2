namespace Shape2;


internal class Cone : Shape, Surface, Volume
{

    public void Kone()
    {
        do
        {
            if (a > 0 || h > 0)
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
        s = 2 * Math.PI * r * (a + r);
    }
    public void V()
    {
        v = (Math.PI * r * r * a) / 3;
    }
    public override void Koxm1()
    {
        Console.WriteLine("Grel koni cnord ");

        do
        {
            koxm1 = Console.ReadLine();
            if (double.TryParse(koxm1.ToString(), out a) && a > 0)
            {
                Console.WriteLine($"l = {koxm1}");
                break;
            }
            else
            {
                Console.WriteLine("jisht che");

            }
        }
        while (true);
    }
}
