using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayFirstGame.Classes
{
    internal class KyoKuShin:Character
    {
        public KyoKuShin(string pseudo, string role) : base(pseudo, role)
        {
            this.specialty = "KyoKuShin";
            this.maxHealth = 100;
            this.health = maxHealth;
            this.attack = 10;
            this.defense = 5;
        }
    }
}
