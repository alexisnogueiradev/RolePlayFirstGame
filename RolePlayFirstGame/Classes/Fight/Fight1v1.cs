using RolePlayFirstGame.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayFirstGame.Classes.Fight
{
    internal class Fight1v1
    {
        Character fighter1, fighter2, winner, looser;
        public int nbRound = 0;
        public Fight1v1(Character player1, Character player2)
        {
            fighter1 = player1;
            fighter2 = player2;
            fighter1.health = fighter1.maxHealth;
            fighter2.health = fighter2.maxHealth;
        }

        public void StartFight()
        {
            Console.WriteLine($"{fighter1.ToString()}\n-----VERSUS-----\n{fighter2.ToString()}\n");
        }

        public bool IsContinuing()
        {
            return fighter1.health > 0 && fighter2.health > 0;
        }

        public void StopFight()
        {
            Console.WriteLine($"Fin du combat \nGagnant : {winner}");
        }
    }
}
