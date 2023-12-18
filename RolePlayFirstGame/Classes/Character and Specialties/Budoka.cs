using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayFirstGame.Classes
{
    internal class Budoka:Character
    {
        public Budoka(string pseudo, string role) : base(pseudo, role)
        {
            this.specialty = "Budoka";
            this.maxHealth = 75;
            this.health = maxHealth;
            this.attack = 12;
            this.defense = 3;
        }

        public override void BaseAttack(Character target)
        {
            
        }



    }
}
