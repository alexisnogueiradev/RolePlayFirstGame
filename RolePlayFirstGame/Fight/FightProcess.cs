using RolePlayFirstGame.Classes;
using RolePlayFirstGame.Classes.Fight;


// Déclaration de chaque personnages
Character char1 = new Character("Alex", "Nak Muay");
Character char2 = new Character("Nico", "Budoka");
Character char3 = new Character("Eddy", "KyoKuShin");

// Création d'une instance de fight

Fight1v1 fightTest = new Fight1v1(char1, char2);

// Initialisation du combat

fightTest.StartFight();

// Début du round


Round firstRound = new Round(char1, char2);


// Fin du fight

fightTest.StopFight();