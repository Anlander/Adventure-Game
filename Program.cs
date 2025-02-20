﻿// See https://aka.ms/new-console-template for more information



Random random = new Random();

string playerClass = "";
string playerName = "";

int playerAttack = 0;
int monsterAttack = 0;





int healthPotion = 0;
bool playerTurn = false;

int monsterHealth = 10;
int playerHealth = 10;

static void WaitToEnter()
{
	Console.ForegroundColor = ConsoleColor.Green;
	Console.WriteLine("\nPress enter to continue..");
	Console.ResetColor();
}

static void StoryTeller(string storyTeller)
{
	Console.ForegroundColor = ConsoleColor.Magenta;
	Console.WriteLine(storyTeller);
	Console.ResetColor();
}



Console.Write("Hello Adventure, welcome to this shitty game\nWho is the hero I speak to?: ");

playerName = Console.ReadLine();

while (String.IsNullOrEmpty(playerName))
{
	Console.Write("Enter a valid name: ");
	playerName = Console.ReadLine();
}

StoryTeller("What class are you playing?");
Console.WriteLine("1: Warrior \n2: Archer\n3: Wizard");


var classChoice = Console.ReadKey(intercept: true).Key;

while (classChoice != ConsoleKey.D3 && classChoice != ConsoleKey.D1)
{

	Console.WriteLine("You choose a class that no one likes, choose another");
	Console.WriteLine("What class are you playing? \n 1: Warrior \n 3: Wizard");
	Console.WriteLine("Choose a class: ");
	classChoice = Console.ReadKey(intercept: true).Key;


}
if (classChoice == ConsoleKey.D1)
	playerClass = "Warrior";
else if (classChoice == ConsoleKey.D3)
	playerClass = "Wizard";

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"{playerName} the great {playerClass.ToLower()}");
Console.ResetColor();
Console.WriteLine("I WELCOME YOU!." +
$"\nI will now take you on a journey that you probably will finish in less than 1 minute");

WaitToEnter();
Console.ReadLine();


StoryTeller("\nAs you wander through the forest, the trees tower above you, their branches thick with leaves," +
	"\ncasting long shadows on the ground. The air is cool and crisp, and the distant sound of rustling leaves fills the silence." +
	"\nThe path ahead seems endless, winding between ancient oaks and small streams.");

WaitToEnter();
Console.ReadLine();


StoryTeller("Suddenly, you hear a noise behind you, a rustling in the bushes. " +
	"\nYour heart races as you turn, a big monster appears...");

Console.ResetColor();

WaitToEnter();

Console.WriteLine("\n1: Fight\n2: Flee");

var fightFlee = Console.ReadKey(intercept: true).Key;

while (fightFlee != ConsoleKey.D1)
{


	Console.WriteLine("");
	Console.WriteLine("    \\   /");
	Console.WriteLine("    (o o) bwak bwak");
	Console.WriteLine("    ( V )");
	Console.WriteLine("    /| |\\");
	Console.WriteLine("   / | | \\");
	Console.WriteLine("  (  | |  )");
	Console.WriteLine("   `-'-'-`");
	Console.WriteLine("");
	Console.WriteLine("\nTry again: ");
	fightFlee = Console.ReadKey(intercept: true).Key;
}

Console.WriteLine("\nGreat!, You choose to fight..");






WaitToEnter();
Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("The monster appears!");
Console.ResetColor();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("         /\\______  __");
Console.WriteLine("        /-~     ,^~ / __ You're DEAD son!");
Console.WriteLine("       / ,---x /_.-'L/__,\\");
Console.WriteLine("      /-.---.\\_.-'/'!\"  \\ \\");
Console.WriteLine("      0\\/0___/   x' /    ) |");
Console.WriteLine("      \\.______.-'_.{__.-\"_.^");
Console.WriteLine("       `x____,.-\",-~( .-\"");
Console.WriteLine("          _.-| ,^.-~ \"\\");
Console.WriteLine("     __.-~_,-|/\\/     `i");
Console.WriteLine("    / u.-~ .-{\\/     .-^--.");
Console.WriteLine("    \\/   v~ ,-^x.____}--r |");
Console.WriteLine("        / /\"            | |");
Console.WriteLine("      _/_/              !_l_");
Console.WriteLine("    o~_//)             (_\\\\_~o");
Console.ResetColor();
Console.WriteLine();

WaitToEnter();
Console.ReadLine();

Console.WriteLine("The fight starts..");



while (playerHealth >= 0 && monsterHealth >= 0)
{
	playerTurn = !playerTurn;


	if (playerTurn == true)
	{
		Console.WriteLine("1: Attack\n2: Health potion\n");
		var key = Console.ReadKey(intercept: true).Key;

		if (key == ConsoleKey.D1)
		{
			playerAttack = random.Next(0, 5);
			monsterHealth = monsterHealth - playerAttack;

			Console.WriteLine($"You attacked for {playerAttack}");
			Console.WriteLine($"-------Monster health: {monsterHealth}/10-------");
		}
		else if (key == ConsoleKey.D2)
		{
			healthPotion = random.Next(0, 5);
			playerHealth = healthPotion + playerHealth;
			if (healthPotion == 0)
				Console.ForegroundColor = ConsoleColor.Red;
			else
				Console.ForegroundColor = ConsoleColor.Green;

			Console.WriteLine($"You healed for {healthPotion}");
			Console.ResetColor();
			if (playerHealth < 4)
				Console.ForegroundColor = ConsoleColor.Red;
			else Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"-------Player health: {playerHealth}/10-------");
			Console.ResetColor();
		}

	}
	else
	{
		monsterAttack = random.Next(0, 5);
		playerHealth = playerHealth - monsterAttack;

		Console.WriteLine($"\nMonster attacked for {monsterAttack}");
		if (playerHealth < 4)
			Console.ForegroundColor = ConsoleColor.Red;
		else Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine($"-------Player health: {playerHealth}/10-------");
		Console.ResetColor();
		Console.WriteLine();
	}

	if (monsterHealth <= 0)
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Monster have been defeated!");
		Console.ResetColor();
		break;
	}
	else if (playerHealth <= 0)
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("\nYou've been destroyed.");
		Console.WriteLine("\nGAME OVER!.");
		Console.ResetColor();
		break;
	}
}



Console.ReadKey();