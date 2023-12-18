using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayFirstGame.Classes
{
    internal class Character
    {
        public string pseudo, specialty;
        public int health, maxHealth, attack, defense;

        public Character(string pseudo, string role)
        {
            this.pseudo = pseudo;
            this.specialty = role;
        }

        public Character(Character player)
        {
            this.pseudo = player.pseudo;
            this.specialty = player.specialty;
        }

/*        public void DeleteCharacter(Character char)
        {
            
        }*/

        public override string ToString()
        {
            return $"Pseudo : {this.pseudo}     Role : {this.specialty}      Vie : {this.health}     Attaque : {this.attack}     Défense : {this.defense}";
        }

        public virtual void BaseAttack(Character target)
        {
            target.health -= attack - target.defense;
        }




    }
}
