using static System.Formats.Asn1.AsnWriter;
using System.Drawing;

namespace Shape2;
internal class Program
{
    static void Main(string[] args)
    {
        Patker();
    }

    static void Patker()
    {
        {
            Console.WriteLine("Yntreq patker: triangle rectangle cylinder cone sphere HCone  ");
            string patker;
            patker = Console.ReadLine();

            if (patker == "triangle")
            {
                Triangle triangle = new Triangle();
                triangle.Koxm1();
                triangle.Koxm2();
                triangle.Koxm3();
                triangle.P();
                triangle.S();
                triangle.Erankyun();
            }
            else if (patker == "rectangle")
            {
                Rectangle rectangle = new Rectangle();
                rectangle.Koxm1();
                rectangle.Koxm2();
                rectangle.Koxm3();
                rectangle.Koxm4();
                rectangle.P();
                rectangle.S();
                rectangle.Uxankyun();
            }
            else if (patker == "cylinder")
            {
                Cylinder cylinder = new Cylinder();
                cylinder.Sharavix();
                cylinder.Bardzrutyun();
                cylinder.S();
                cylinder.V();
                cylinder.Glan();
            }
            else if (patker == "cone")
            {
                Cone cone = new Cone();
                cone.Sharavix();
                cone.Koxm1();     //cnord
                cone.S();
                cone.V();
                cone.Kone();
            }
            else if ((patker == "phere"))
            {
                Sphere sphere = new Sphere();
                sphere.Sharavix();
                sphere.S();
                sphere.V();
                sphere.Gund();
            }
            else
            {
                HCone hCone = new HCone();
                hCone.Sharavix();
                hCone.Koxm1();
                hCone.Koxm4();
                hCone.Bardzrutyun();
                hCone.S();
                hCone.V();
                hCone.HatacCone();
            }


            Console.ReadKey();


        }
    }

}