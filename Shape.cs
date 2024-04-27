namespace Shape2;

internal class Shape
{
    public double a;
    public double b;
    public double c;
    public double d;
    public double r;
    public double h;
    public string koxm1;
    public string koxm2;
    public string koxm3;
    public string koxm4;
    public string radius;
    public string hight;
    public double p;
    public double s;
    public double v;

    public virtual void Koxm1()
    {
        Console.WriteLine("Grel 1 koxmy");

        do
        {
            koxm1 = Console.ReadLine();
            if (double.TryParse(koxm1.ToString(), out a) && a > 0)
            {
                Console.WriteLine($"a = {koxm1}");
                break;
            }
            else
            {
                Console.WriteLine("sxal koxm e");

            }
        }
        while (true);
    }
    public void Koxm2()
    {
        Console.WriteLine("Grel 2 koxmy");

        do
        {
            koxm2 = Console.ReadLine();
            if (double.TryParse(koxm2.ToString(), out b) && b > 0)
            {
                Console.WriteLine($"b = {koxm2}");
                break;
            }
            else
            {
                Console.WriteLine("sxal koxm e");

            }
        }
        while (true);
    }
    public void Koxm3()
    {
        Console.WriteLine("Grel 3 koxmy");

        do
        {
            koxm3 = Console.ReadLine();
            if (double.TryParse(koxm3.ToString(), out c) && c > 0)
            {
                Console.WriteLine($" c = {koxm3}");
                break;
            }
            else
            {
                Console.WriteLine("sxal koxm e");

            }
        }
        while (true);

    }

    public virtual void Koxm4()
    {
        Console.WriteLine("Grel 4 koxmy");
        do

        {
            koxm4 = Console.ReadLine();
            if (double.TryParse(koxm4.ToString(), out d) && d > 0)
            {
                Console.WriteLine($" d = {koxm4}");
                break;
            }
            else
            {
                Console.WriteLine("sxal koxm e");

            }
        }
        while (true);
    }
    public void Sharavix()
    {

        Console.WriteLine("Grel sharavix");
        do
        {
            radius = Console.ReadLine();
            if (double.TryParse(radius.ToString(), out r) && r > 0)
            {
                Console.WriteLine($"r = {radius}");
                break;
            }
            else
            {
                Console.WriteLine("Goyutun chni");
            }
        }
        while (true);
    }
    public void Bardzrutyun()
    {

        Console.WriteLine("Grel bardzrutyuny");
        do
        {
            hight = Console.ReadLine();
            if (double.TryParse(hight.ToString(), out h) && h > 0)
            {
                Console.WriteLine($"h = {hight}");
                break;
            }
            else
            {
                Console.WriteLine("Goyutun chni");
            }
        }
        while (true);
    }
}
