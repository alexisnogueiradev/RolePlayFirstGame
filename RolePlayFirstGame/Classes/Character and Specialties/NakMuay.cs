using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayFirstGame.Classes
{
    internal class NakMuay:Character
    {
        public NakMuay(string pseudo, string role):base(pseudo, role)
        {
            this.specialty = "Nak Muay";
            this.maxHealth = 50;
            this.health = maxHealth;
            this.attack = 15;
            this.defense = 0;
        }


    }
}
