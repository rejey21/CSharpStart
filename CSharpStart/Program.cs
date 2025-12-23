// Here is the complete code for a simple C# console application that simulates a battle between a player and a mob using classes and methods.
using System;
/*
class Program
{
    static void Main()
    {
        Player player = new("Winker21", 100, 25);
        Enemy mob = new("Goblin", 15);

        Random random = new Random();

        Console.WriteLine("Battle Start!");

        while (player.IsAlive() && mob.IsAlive())
        {
            mob.AttackPlayer(player);
            player.AttackEnemy(mob);

            if (!player.IsAlive())
                break;

            if (!mob.IsAlive())
                break;

            if (random.Next(1, 4) == 2 && !player.HasPotion)
            {
                player.HasPotion = true;
                Console.WriteLine("God sends a potion!");
            }

            player.PrintStatus();
            player.TryUsePotion();
            Console.WriteLine("---- NEXT TURN ----");
        }

        if (!player.IsAlive())
        {
            Console.WriteLine("Mob wins!");
        }
        else if (!mob.IsAlive())
        {
            Console.WriteLine("Player is wins!");
        }
    }
}
*/


// Starting code of a simple C# console application

/*
    Console.WriteLine("Hello, GameDev!");
    Console.WriteLine("I'm a learning C#");
*/

// What is variable

/*
 * It's a named storage location in memory that holds a value of a specific data type.
*/

// For example, let's declare some variables:
/*
    int health = 100; // Integer variable to store number
    float speed = 5.5f; // Floating-point variable to store decimal number (yuo can use a double or decimal)
    string playerName = "Winker21"; // String variable to store text (if you need store only one letter/number or even else use this variable - char.)
    bool isAlive = true; // Boolean variable to store true/false value
    bool hasPotion = false; 
    int playerAttack = 25;
    int mobAttack = 25;
    int attackCount = 0;
    Random random = new Random(); // Random number generator
*/

// Quest 1: Output charachter attributes:

// Console.WriteLine($"Player Name: {playerName} | HP: {health} | ATK: {playerAttack} | Speed: {speed}");

// Quest 2: Simulate taking damage:
/*
    health -= mobAttack; // First attack
    Console.WriteLine($"Player get {mobAttack} damage. Current HP: {health}");
    health -= mobAttack; // Second attack
    Console.WriteLine($"Player get {mobAttack} damage. Current HP: {health}");
*/

// Now we learn some intresting things, and it's if/else statement
// It's looks like this:

/*
  if (condition) 
  {
     // code to execute if condition is true
  } else 
  {
     // code to execute if condition is false
  }
*/

// We have many operators for our conditions:

/*
    == - equal to
    != - not equal to
    >  - greater than
    <  - less than
    >= - greater than or equal to
    <= - less than or equal to
*/

// Now let's use if/else on practice:

/*
    if (health <= 0) 
    {
        Console.WriteLine("Player Dead!");
    }
*/

// Also we have logical operators:
/*
    && - logical AND
    || - logical OR
    !  - logical NOT
*/

// Let's use logical operators in our condition:

/*
    if (health > 0 && isAlive) 
    {
        Console.WriteLine("Player is still alive and kicking!");
    }
*/

// Quest 3: Dead Player Check

/*
    health -= mobAttack; // Attack our charachter

    if (health <= 0) 
    {
        isAlive = false;
        Console.WriteLine("Player has died.");
    }
    else 
    {
        Console.WriteLine($"Player is still alive. He's current HP - {health}");
    }
*/

// Quest 4: Player Status Check && Quest 5: Health Potion Usage If In Critical Condition

/*
    health -= mobAttack; // Attack our charachter

    if (health > 70)
    {
        Console.WriteLine("Status is good");
    }
    else if (health <= 70 && health >= 31)
    {
        Console.WriteLine("Status is wounded");
    }
    else if (health > 0 && health <= 30)
    {
        Console.WriteLine("Status is critical");
        if (hasPotion)
        {
            Console.WriteLine("Using health potion...");
            health += 40;
            hasPotion = false; // Potion used
            Console.WriteLine($"Player healed. Current HP: {health}");
        }
    }
    else
    {
        Console.WriteLine("Player is dead");
    }

    health -= mobAttack; // Attack our charachter

    if (health > 70)
    {
        Console.WriteLine("Status is good");
    }
    else if (health <= 70 && health >= 31)
    {
        Console.WriteLine("Status is wounded");
    }
    else if (health > 0 && health <= 30)
    {
        Console.WriteLine("Status is critical");
        if (hasPotion)
        {
            Console.WriteLine("Using health potion...");
            health += 40;
            hasPotion = false; // Potion used
            Console.WriteLine($"Player healed. Current HP: {health}");
        }
    }
    else
    {
        Console.WriteLine("Player is dead");
    }

    health -= mobAttack; // Attack our charachter

    if (health > 70)
    {
        Console.WriteLine("Status is good");
    }
    else if (health <= 70 && health >= 31)
    {
        Console.WriteLine("Status is wounded");
    }
    else if (health > 0 && health <= 30)
    {
        Console.WriteLine("Status is critical");
        if (hasPotion)
        {
            Console.WriteLine("Using health potion...");
            health += 40;
            hasPotion = false; // Potion used
            Console.WriteLine($"Player healed. Current HP: {health}");
        }
    }
    else
    {
        Console.WriteLine("Player is dead");
    }
*/

// Next what we need learn is loops
// Why we need learning loops?
// Because loops allow us to execute a block of code multiple times, which is useful for repetitive tasks.
// In games, loops spawn enemies by waves, repeat waves until the player dies or win, and many more.

// The most common loops are for and while loops
// For loop example:
/*
    for (int i = 0; i < 5; i++)
    {
        some code;
    }
*/

/*
    In first part we declare and initialize our loop variable
    In second part we set condition for loop to run
    In third part we increase our loop variable by 1 (also we can decrease it or do something else)
*/

// While loop example:

/*
    while (condition)
    {
        some code;
    }
*/

/*
    In while loop we just set condition for loop to run
    While loop will continue to execute as long as the condition is true (but be careful to avoid infinite loops!)
*/

// Break and continue statements are also useful in loops:
// Break statement example:
/*
    for (int i = 0; i < 10; i++)
    {
        if (i == 5)
        {
            break; // Exit the loop when i is 5
        }
        Console.WriteLine(i);
    }
*/

// Quest 6: Simulate Multiple Attacks Until Player Death (loop for)

/*
    for (int attackCount = 1; attackCount <= 6; attackCount++) 
    {
        health -= mobAttack; // Attack our charachter

        if (health > 70)
        {
            Console.WriteLine("Status is good");
        }
        else if (health <= 70 && health >= 31)
        {
            Console.WriteLine("Status is wounded");
        }
        else if (health > 0 && health <= 30)
        {
            Console.WriteLine("Status is critical");
            if (hasPotion)
            {
                Console.WriteLine("Using health potion...");
                health += 40;
                hasPotion = false; // Potion used
                Console.WriteLine($"Player healed. Current HP: {health}");
            }
        }
        else
        {
            Console.WriteLine("Player is dead");
            break; // Exit the loop if player is dead
        }

        if (attackCount == 2)
        {
            hasPotion = true; // Give player a health potion after 3 attacks
            Console.WriteLine("God's senting to player a potion!");
        }
        else
        {
            continue; // Continue to next attack
        }
    }
*/

// Quest 7: Simulate Multiple Attacks Until Player Death (loop while)

/*
    while (health > 0 && attackCount < 5) 
    {
        attackCount++;
        int chanceCriticalHit = random.Next(1, 101); // Random number between 1 and 100

        if (chanceCriticalHit <= 20)
        {
            health -= mobAttack + mobAttack; // Critical hit deals double damage
            Console.WriteLine("Critical Hit!");
        }
        else
        {
            health -= mobAttack; // Normal hit
        }

        if (health > 70)
        {
            Console.WriteLine("Status is good");
        }
        else if (health <= 70 && health >= 31)
        {
            Console.WriteLine("Status is wounded");
            if (attackCount == 2)
            {
                hasPotion = true; // Give player a health potion after 2 attacks
                Console.WriteLine("God's senting to player a potion!");
            }
        }
        else if (health > 0 && health <= 30)
        {
            Console.WriteLine("Status is critical");
            if (hasPotion)
            {
                Console.WriteLine("Using health potion...");
                health += 40;
                hasPotion = false; // Potion used
                Console.WriteLine($"Player healed. Current HP: {health}");
            }
        }
        else
        {
            Console.WriteLine("Player is dead");
            break; // Exit the loop if player is dead
        }
    }
*/

// That's all for now! You've learned about variables, if/else statements, and loops in C#.
// Now we learn methods in C#

// What is method?
/*
    Method is a block of code that performs a specific task and can be called upon when needed.
    Method = action
    Methods help to organize code, make it reusable, and improve readability.
    How it looks:
    
    MethodName(condition) // Here we call our method

    returnType MethodName(parameters) // Here we declare our method
    {
        method body // code to be executed
    }
*/

// Quest 8 + Quest 9: Create a Method for Player Status Check and battle simulation with critical hits and health potions

/*
    int health = 100;
    int mobAttack = 15, playerAttack = 25;
    string playerName = "Winker21";
    bool isAlive = true;
    bool hasPotion = false;
    Random random = new Random();
    Console.WriteLine($"Player Name: {playerName} | HP: {health} | ATK: {playerAttack}");

    void TakeDamage(int damage)
    {
        int criticalHitChance = random.Next(1, 101); // Random number between 1 and 100
        int criticalDamage = 0;

        if (criticalHitChance <= 20)
        {
            criticalDamage = damage * 2;
            health -= criticalDamage;
            Console.WriteLine("Critical Hit!");
            Console.WriteLine($"Player get {criticalDamage} damage. Current HP: {health}");
        }
        else
        {
            health -= damage;
            Console.WriteLine($"Player get {damage} damage. Current HP: {health}");
        }
    }

    void TryUsePotion()
    {
        if (!hasPotion)
        {
            return; // No need to use potion
        }
        else if (health <= 30)
        {
            Console.WriteLine("Using health potion...");
            HealPlayer(40);
            hasPotion = false; // Potion used
        }
    }

    void HealPlayer(int healAmount)
    {
        health += healAmount;
        Console.WriteLine($"Player healed. Current HP: {health}");
    }

    void CheckPlayerStatus()
    {
        if (health <= 0) 
        {
            Console.WriteLine("Player Dead!");
            return;
        }

        if (health > 70)
        {
            Console.WriteLine("Status is good");
        }
        else if (health >= 31 && health <= 70)
        {
            Console.WriteLine("Status is wounded");
        }
        else
        {
            Console.WriteLine("Status is critical");
            TryUsePotion();
        }
    }

    bool IsAliveCheck()
    {
        if (health <= 0)
        {
            isAlive = false;
            return isAlive;
        }
        else
        {
            return isAlive;
        }
    }

    Console.WriteLine("Battle Start!"); 
    while (IsAliveCheck())
    {
        TakeDamage(mobAttack);
        if (health <= 0)
        {
            CheckPlayerStatus();
            break;
        }
        if (random.Next(1, 4) == 2 && !hasPotion) // 1 in 3 chance to get a potion
        {
            hasPotion = true;
            Console.WriteLine("God's senting to player a potion!");
        }

        // важно: вызываем проверку статуса каждый раунд,
        // чтобы при критическом HP и наличии зелья оно использовалось сразу
        CheckPlayerStatus();
        isAlive = IsAliveCheck();
    }
*/

// You've learned about methods in C# and how to use them to organize your code better.
// Classes and OOP in C#

// What is class?
/*
    A class is a blueprint for creating objects. It defines the properties (attributes) and behaviors (methods) that the objects created from the class will have.
    Class = blueprint
    Classes help to encapsulate data and functionality, making code more modular and easier to manage.
    How it looks:

    class ClassName // Here we declare our class
    {
        // properties and methods
    }

    Object = instance of a class
    How it looks:

    ClassName objectName = new ClassName(); // Here we create an object from a class
*/

// For example, let's create a simple class for a Player:
/*
    class Player
    {
        // Properties
        public string Name;
        public int Health;
        public int AttackPower;
        // Constructor
        public Player(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }
        // Method
        public void Attack(Player target)
        {
            target.Health -= AttackPower;
            Console.WriteLine($"{Name} attacks {target.Name} for {AttackPower} damage!");
        }
    }
*/

// Quest 10 && Quest 11: Create Player and Mob Classes and Simulate a Battle
/*
    class Player
    {
        public string Name;
        public int CurrentHealth;
        public int MaxHealth = 100;
        public int Attack = 25;
        public bool HasPotion;

        static Random random = new Random();

        public Player(string name, int currentHealth, int attack)
        {
            Name = name;
            CurrentHealth = currentHealth;
            Attack = attack;
            HasPotion = false;
        }

        public bool IsAlive()
        {
            return CurrentHealth > 0;
        }

        public void AttackEnemy(Enemy enemy)
        {
            enemy.TakeDamage(Attack);
        }   

        public void TakeDamage(int damage)
        {
            if (random.Next(1, 101) <= 20)
            {
                damage *= 2;
                Console.WriteLine("Critical Hit!");
            }

            CurrentHealth -= damage;
            Console.WriteLine($"{Name} takes {damage} damage. HP: {CurrentHealth}");
        }

        public void Heal(int amount)
        {
            CurrentHealth += amount;
            if (CurrentHealth > MaxHealth)
            {
                CurrentHealth = MaxHealth;
                Console.WriteLine($"Your HP not can be more than {MaxHealth}. So we restore to full your HP: {CurrentHealth}");
                return;
            }
            Console.WriteLine($"{Name} healed for {amount}. HP: {CurrentHealth}");
        }

        public void TryUsePotion()
        {
            if (!HasPotion || CurrentHealth > 30)
                return;

            Console.WriteLine($"{Name} uses a potion!");
            Heal(40);
            HasPotion = false;
        }

        public void PrintStatus()
        {
            if (CurrentHealth > 70)
            {
                Console.WriteLine("Status: Good");
            }
            else if (CurrentHealth > 30 && CurrentHealth <= 70)
            {
                Console.WriteLine("Status: Wounded");
            }
            else
                Console.WriteLine("Status: Critical");
        }
    }

    class Enemy
    {
        public string Name;
        public int Health = 100;
        public int Attack = 15;

        static Random random = new Random();

        public Enemy(string name, int attack)
        {
            Name = name;
            Attack = attack;
        }

        public void AttackPlayer(Player player)
        {
            player.TakeDamage(Attack);
        }

        public bool IsAlive()
        {
            return Health > 0;
        }

        public void TakeDamage(int damage)
        {
            if (random.Next(1, 101) <= 20)
            {
                damage *= 2;
                Console.WriteLine("Critical Hit!");
            }

            Health -= damage;
            Console.WriteLine($"{Name} takes {damage} damage. HP: {Health}");
        }
    }
*/