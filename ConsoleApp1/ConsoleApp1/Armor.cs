using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Armor : Equipment
    {
        private string[] armor = {"Leather Armor", "Knight Set", "Gold-Helmed Robe"};
        private string[] armorDescr = {"Sturdy leather armor. Provides solid defense.", "Armor of a low ranking knight. Despite the thin material, it provides good protection.", "Ancient robe from a time long-forgotten. Provides solid defense again fire." };

        public Armor()
        {
            Console.WriteLine("Armor Library Initialized");
            this.SetEquipment(armor, armorDescr);
        }

    }
}
