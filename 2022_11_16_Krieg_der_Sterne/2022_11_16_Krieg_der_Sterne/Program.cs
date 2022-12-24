//Imports######################################################
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//#############################################################

//Classes######################################################
class Flotte
{
    protected int Flottenzahl;
    protected int Besatzung = 500000;
    protected int gefallene_Besatzung;
    protected int zerstörte_gegnerische_Schiffe;
}

class XWing:Flotte
{
    public XWing()
    {
        base.Besatzung = 2;
    }
    
    public void Treffer()
    {
        Console.WriteLine("XWing getroffen");
    }
}

class Sternenzerstörer:Flotte
{
    public Sternenzerstörer()
    {
        base.Besatzung = 37085;
    }

    public void Treffer()
    {
        Console.WriteLine("Sternenzerstörer getroffen");
    }
}

class Todesstern:Flotte
{
    public Todesstern()
    {
        base.Besatzung = 265657;
    }

    public void Treffer()
    {
        Console.WriteLine("Todesstern getroffen");
    }
}
//#############################################################

namespace _2022_11_16_Krieg_der_Sterne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Code#############################################
            XWing Rot_Führer = new XWing();
            XWing Rot_5 = new XWing();
            XWing Rot_2 = new XWing();
            XWing Rot_3 = new XWing();

            Sternenzerstörer Anihilator = new Sternenzerstörer();
            Sternenzerstörer Devastator = new Sternenzerstörer();
            Sternenzerstörer Eliminator = new Sternenzerstörer();

            Todesstern Deathstar = new Todesstern();



            Deathstar.Treffer();
            Rot_Führer.Treffer();
            //#################################################

            Console.WriteLine("Press ENTER to exit...");
            Console.ReadKey();
        }

        //Functions############################################
        //#####################################################
    }
}