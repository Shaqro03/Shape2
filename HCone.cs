namespace Shape2;

internal class HCone : Shape, Surface, Volume
{
    public void HatacCone()
    {
        do
        {
            if (a > r)

            {
                Console.WriteLine($"S =  {s}");
                Console.WriteLine($"V =  {v}");

                break;
            }

            else
            {
                Console.WriteLine("Sxal e");
                Koxm1(); //R
                Sharavix(); //r
                Bardzrutyun();// h
                Koxm4();    //cnord
            }
        }
        while (true);

    }
    public void S()
    {
        s = Math.PI * (a + r) * d + Math.PI * a * a + Math.PI * r * r;
    }
    public void V()
    {
        v = ((Math.PI * h) * (a * a + r * r + a * r)) / 3;
    }

    public override void Koxm1()
    {
        Console.WriteLine("Grel R");

        do
        {
            koxm1 = Console.ReadLine();
            if (double.TryParse(koxm1.ToString(), out a) && a > 0)
            {
                Console.WriteLine($"R = {koxm1}");
                break;
            }
            else
            {
                Console.WriteLine("sxal e");

            }
        }
        while (true);
    }
    public override void Koxm4()
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
