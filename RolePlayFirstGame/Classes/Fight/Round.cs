using RolePlayFirstGame.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayFirstGame.Classes.Fight
{
    internal class Round : Fight1v1
    {
        public bool playOrderFighter1, playOrderFighter2;
        public Round(Character player1, Character player2) : base(player1, player2)
        {
            playOrderFighter1 = GenerateRandomBool();
            nbRound = 1;
        }

        public bool GenerateRandomBool()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return random.Next(2) == 0;
        }
    }
}
