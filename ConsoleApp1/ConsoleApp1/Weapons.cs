using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Weapons : Equipment
    {
        private string[] swords = { "Shortblade", "Longblade", "Claymore", "Bastard Sword" };
        private string[] swordsDesc = { "This small straight sword is widely used, to an extent only matched by the longsword.", "Widely-used standard straight sword, only matched in ubiquity by the shortsword", "This larger type of greatsword is normally wielded with two hands due to its weight.", "This standard greatsword is normally wielded with two hands due to its great weight." };

        public Weapons()
        {
            Console.WriteLine("Weapon Library Initialized");
            this.SetEquipment(swords, swordsDesc);
            /*
            for(int x = 0; x < swords.Length; ++x)
            {
                this.SetEquipment(swords[x]);
                this.SetDescription(swordsDesc[x]);
               /Console.WriteLine(x + " " + swords[x]);
            }
            */
        }

    }
}
