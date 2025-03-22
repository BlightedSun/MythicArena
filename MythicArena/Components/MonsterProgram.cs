






//GameLogic gameLogic = new GameLogic();

////creating the enemy and player parties.
//List<Monster> _playerParty = new List<Monster>();

////enemy takes Kelpie every time. for now
//List<Monster> _enemyParty = new List<Monster>();
//_enemyParty.Add(gameLogic._monsters.Find(monster => monster.Name == "Kelpie"));

////may remove later
//Random random = new Random();

////player picks their monster
//Console.WriteLine("Pick 1 monster by typing its name: ");
//gameLogic.PrintMonsterList();
//string playerchoice = Console.ReadLine();
//_playerParty.Add(gameLogic._monsters.Find(monster => monster.Name == playerchoice));

////announce monsters
//Console.WriteLine("Player has chosen " + _playerParty.First().Name);
//Console.WriteLine("Enemy has chosen " + _enemyParty.First().Name);


////active monsters set to first in the list
//Monster activePlayer = _playerParty.First();
//Monster activeEnemy = _enemyParty.First();


////who goes first? looks at speed 
//bool playerFirst = false;
//if (activePlayer.Speed >= activeEnemy.Speed)
//{
//    playerFirst = true;
//}


////combat
//while (!activePlayer.IsDead && !activeEnemy.IsDead)
//{




//    if (playerFirst)
//    {
//        Console.WriteLine(activePlayer.Name + " HP = " + activePlayer.Hp + "  |  " + activeEnemy.Name + " HP = " + activeEnemy.Hp);

//        Console.WriteLine("Type '1' to attack. Type 'exit' to quit program.");
//        string choice = Console.ReadLine();

//        if (choice == "1")
//        {
//            activePlayer.Attack(activeEnemy);

//        }
//        //add more actions
//        else if (choice == "2")
//        {
//            //activePlayer.Attack(activeEnemy);
//        }

//    }

//    playerFirst = true;

//    Console.WriteLine(activePlayer.Name + " HP = " + activePlayer.Hp + "  |  " + activeEnemy.Name + " HP = " + activeEnemy.Hp);

//    //break out if anyone is dead
//    if (activePlayer.IsDead || activeEnemy.IsDead) break;


//    //enemy picks random action
//    Console.WriteLine("Enemy turn: ");
//    int rand = random.Next(0, 2);
//    if (rand == 0)
//    {
//        activeEnemy.Attack(activePlayer);
//    }
//    //can add extra action here
//    else
//    {
//        activeEnemy.Attack(activePlayer);
//    }

//    if (activePlayer.IsDead || activeEnemy.IsDead) break;
//}

////after combat is over
//Console.WriteLine("Game will close.");



