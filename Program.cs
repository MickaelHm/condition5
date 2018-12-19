using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fujita = new string[6];
            fujita[0] = "Dégâts légers: certains dommages sont subis par les cheminées, les antennes de télévision, les bardeaux, les arbres, les enseignes et les fenêtres.";
            fujita[1] = "Dégâts modérés : les automobiles sont renversées, les abris pour automobiles détruits et les arbres déracinés.";
            fujita[2] = "Dégâts importants: les toits sont arrachés par le vent, les hangars et les dépendances sont démolies et les maisons mobiles sont renversées.";
            fujita[3] = "Dégâts considérables : les murs extérieurs et les toits sont projetés dans les airs, les maisons et les bâtiments de métal s'effondrent ou subissent des dégâts";
            fujita[4] = "Dégâts incroyables : les maisons sont rasées ou projetées sur de grandes distances. Les tornades F5 peuvent causer des dommages très importants à de grosses structures telles que les écoles et les motels et peuvent arracher les murs extérieurs et les toits (parfois surnommé « le doigt de Dieu ».";
            Console.WriteLine("Veuillez renseigner le type d'un tornade sous le format \"Fx\" ou \"x\" correspond au numéro de la tornade");
            string tornadeType = Console.ReadLine();
            if (tornadeType == "F1")
            {
                Console.WriteLine(fujita[0]);
            }
            else
            {
                if (tornadeType == "F2")

                    Console.WriteLine(fujita[1]);
                else
                {
                    if (tornadeType == "F3")

                        Console.WriteLine(fujita[2]);
                    else
                    {
                        if (tornadeType == "F4")

                            Console.WriteLine(fujita[3]);
                        else
                        {
                            if (tornadeType == "F5")

                                Console.WriteLine(fujita[4]);
                        }
                    }
                }
            }
        }
    }
}
