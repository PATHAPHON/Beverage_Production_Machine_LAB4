using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Ingredient
    {
        public int water;
        public int coffee;
        public int milk;
        public int chocolate;
        public Ingredient()
        {
            water = 10000;
            coffee = 500;
            milk = 500;
            chocolate = 500;
        }
        public bool makeBlackCoffee()
        {
            if (water >= 300 && coffee >= 20)
            {
                //can make blackCoffee
                water = water - 300;
                coffee = coffee - 20;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool makeLatte()
        {
            if (water >= 200 && coffee >= 20 && milk >= 10)
            {
                //can make Latte
                water = water - 200;
                coffee = coffee - 20;
                milk = milk - 10;
                return true;
            }

            else
            {

                return false;
            }
        }
        public bool makeMocha()
        {
            if (water >= 300 && coffee >= 20 && chocolate >= 10)
            {
                water = water - 300;
                coffee = coffee - 20;
                chocolate = chocolate - 10;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool makeChocolate()
        {
            if (water >= 300 && chocolate >= 20)
            {
                water = water - 300;
                chocolate = chocolate - 20;
                return true;
            }
            else
            {
                return false;
            }

        }
        
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
