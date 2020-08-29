```java
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Pokemon
    {


        private int hp_base;

        public int HP_Base
        {
            get { return hp_base; }
            set { hp_base = value; }
        }

        private int attack_base;

        public int Attack_Base
        {
            get { return attack_base; }
            set { attack_base = value; }
        }

        private int defense_base;

        public int Defense_Base
        {
            get { return defense_base; }
            set { defense_base = value; }
        }

        private int speed_base;

        public int Speed_Base
        {
            get { return speed_base;  }
            set { speed_base = value; }
        }

        private int specialattack_base;

        public int SpecialAttack_Base
        {
            get { return specialattack_base; }
            set { specialattack_base = value; }
        }

        private int specialdefense_base;

        public int SpecialDefense_Base
        {
            get { return specialdefense_base; }
            set { specialdefense_base = value; }
        }

        public int Nummer { get; set; } = -1;
        public string Naam { get; set; } = "Onbekend";
        public string Type { get; set; } = "no type";

        //Level

        private int level;

        public int Level
        {
            get { return level; }
            private set { level = value; }
        }

        public void VerhoogLevel()
        {
            Level++;
        }

        public double Average
        {
            get
            {
                double gemiddelde = 0;
                gemiddelde = Total / 6.0;
                return gemiddelde;
            }
        }

        public int Total
        {
            get
            {
                return (HP_Base + Defense_Base + Attack_Base + SpecialAttack_Base + SpecialDefense_Base + Speed_Base);
            }
        }

        public int HP_Full
        {
            get
            {
                int resultaat = (((HP_Base + 50) * Level) / 50) + 10;
                return resultaat;
            }
        }

        public int Speed_Full
        {
            get
            {
                return ((Speed_Base * Level) / 50) + 5;
            }
        }


    }
}
```