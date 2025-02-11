//   See https:aka.ms/new-console-template for more information
//   Console.WriteLine("Hello, C#!");

//   Call methods from the .NET Class Library using C#endregion

//   Random dice = new Random();
//   int roll = dice.Next(1, 7);
//   Console.WriteLine(roll);

//   int number = 7;
//   string text = "seven";


//   Console.WriteLine(number);
//   Console.WriteLine();
//   Console.WriteLine(text);

//   Random dice = new Random();
//   int roll1 = dice.Next();
//   int roll2 = dice.Next(101);
//   int roll3 = dice.Next(50, 101);

//   Console.WriteLine($"First roll: {roll1}");
//   Console.WriteLine($"Second roll: {roll2}");
//   Console.WriteLine($"Third roll: {roll3}");

//   int firstValue = 500;
//   int secondValue = 600;
//   int largerValue = Math.Max(firstValue, secondValue);

//   Console.WriteLine(largerValue);

//   Add decision logic to your code using 'if', 'else if', and 'else' statements in C#.

//  Random dice = new Random();

//   int roll1 = dice.Next(1, 7);
//   int roll2 = dice.Next(1, 7);
//   int roll3 = dice.Next(1, 7);

//  int roll1 = 1;
//  int roll2 = 4;
//  int roll3 = 1;

//  int total = roll1 + roll2 + roll3;

//  Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//  if((roll1 == roll2 || (roll2 == roll3) || (roll1 == roll3))) {
//  if((roll1 == roll2) && (roll2 == roll3)) {
//  Console.WriteLine("You rolled triples! +6 bonus to total!");
//  total += 6;
//  }
//  else {
//  Console.WriteLine("You rolled doubles! +2 bonus to total!");
//  total += 2;
//  }
//  Console.WriteLine($"Your total including the bonus: {total}");
//  }



//  if (total >= 16) {
//  Console.WriteLine("You win a new car!");  
//  }
//  else if (total >= 10)
//  {
//  Console.WriteLine("You win a new laptop!");
//  }
//  else if (total == 7) 
//  {
//  Console.WriteLine("You win a trip for two!");
//  }
//  else {
//  Console.WriteLine("You win a kitten!");
//  }

//   Random random = new Random();
//   int daysUntilExpiration = random.Next(12);
//   int discountPercentage = 0;

//  Your code goes here

//   if (daysUntilExpiration == 0){
//     Console.WriteLine("Your subscription has expired");
//   }
//   else if (daysUntilExpiration == 1) {
//     Console.WriteLine("Your subscription expires within a day!\nRenew now and save 20%!");
//     discountPercentage = 20;
//   }
//   else if (daysUntilExpiration <= 5) {
//     Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days.\nRenew now and save 10%!");
//     discountPercentage = 10;
//   }
//   else if (daysUntilExpiration <= 10) {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
//   }

//   if (discountPercentage > 0) {
//     Console.WriteLine($"Renew now and save {discountPercentage}%.");
//   }

//   Store and iterate through sequence of data using Arrays and the foreach statement in C#

//   string[] fraudulentOrderIDs = new string[3];

//   fraudulentOrderIDs[0] = "A123";
//   fraudulentOrderIDs[1] = "B456";
//   fraudulentOrderIDs[2] = "C789";
//   fraudulentOrderIDs[3] = "D000";

//   string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

//   Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
//   Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
//   Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

//   fraudulentOrderIDs[0] = "F000";

//   Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
//   Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

//   int[] inventory = {200, 450, 700, 175, 250};
//   int sum = 0;
//   int bin = 0;

//   foreach (int items in inventory) {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
//   }

//   Console.WriteLine($"We have {sum} items in inventory.");

//   string[] fraudulentOrderIDs = ["B123", "C234", "A345", "C15", "B177", "G3001", "C235", "B179"];

//   foreach (string orderID in fraudulentOrderIDs) {
//     if (orderID.StartsWith("B")) {
//     Console.WriteLine("Canceling order " + orderID + " (B)");
//     } else if (orderID.StartsWith("C")) {
//     Console.WriteLine("Contact customer about order " + orderID + " (C)");
//     } else {
//     Console.WriteLine("Order " + orderID + " requires no action.");
//     }
//   }

//   Create readable code with conventions, whitespace, and comments in C#

//  string firstName = "Bob";
//  int widgetsPurchased = 7;
//   Testing a change the message
//   int widgetsSold = 7;
//   Console.WriteLine($"{firstName} sold {widgetsSold} widgets!");
//  Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");

// /*
//   The following code creates five random orderIDs
//   to test the fraud detection process. OrderIDs
//   consist of a letter from A to E, and a three
//   digit number. Ex. A123.
// */
//  Random random = new Random();
//  string[] orderIDs = new string[5];

//  for (int i = 0; i < orderIDs.Length; i++) {
//    int prefixValue = random.Next(65, 70);
//    string prefix = Convert.ToChar(prefixValue).ToString();
//    string suffix = random.Next(1, 1000).ToString("000");

//    orderIDs[i] = prefix + suffix;
//  }
//   Print out each other ID
//  foreach (var orderID in orderIDs) {
//    Console.WriteLine(orderID);
//  }

//  Example 1
// Console.
// WriteLine
// (
//   "Hello Example 1!"
// )
// ;

//  Example 2
// string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");

// Random dice =  new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll2)) {
//     if ((roll1 == roll2) && (roll2 == roll3)) {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         total += 6;
//     } else {
//         Console.WriteLine("You rolled doubles! +2 bonus to total!");
//         total += 2;
//     }
// }

/*
    The provided code snippet processes a string by first converting it into a 
    character array and then reversing the order of the characters in the array.
    It also initializes a counter to keep track of the occurrences of the character 'o'.
    The code then iterates through the reversed character array, counting how many times the character 'o' appears.
*/
// string str = "The quick brown fox jumps over the lazy dog.";

// char[] charMessage = str.ToCharArray();

// Array.Reverse(charMessage);

// int oCount = 0;

// foreach (char character in charMessage) {
//     if (character == 'o') {
//         oCount++;
//     }
// }

// string new_message = new String(charMessage);

// Console.WriteLine(new_message);
// Console.WriteLine($"'o' appears {oCount} times."); 

// Evaluate Boolean expressions to make decisions in C#

// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));

// int a = 7;
// int b = 6;
// Console.WriteLine(a != b);
// string s1 = "Hello";
// string s2 = "Hello";
// Console.WriteLine(s1 != s2);

// int saleAmount = 1001;
// // int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

// string[] coinFlip = new string[2] {"heads", "tails"};
// Random coin = new Random();
// int flip = random.Next(0, 2);
// Console.WriteLine($"Coin flip: {(flip == 0? "heads" : "tails")}");
// Console.WriteLine($"Coin flip: {(coin.Next(0, 2) == 0 ? "heads" : "tails")}");
// Console.WriteLine($"Coin flip: {coinFlip[flip]}");

// string permission = "Admin";
// int level = 60;

// Console.WriteLine(
//     permission.Contains("Admin") && level > 55? "Welcome, Super Admin User." :
//     permission.Contains("Admin") && level <= 55 ? "Welcome Admin User." :
//     permission.Contains("Manager") && level >= 20 ? "Contact an Admin for access." :
//     permission.Contains("Manager") && level < 20 ? "You do not have sufficient privileges." :
//     "You do not have sufficient privileges.");

// Control the scope and logic using code blocks in C#

// bool flag = true;

// if (flag) Console.WriteLine(flag);

// string name = "steve";

// if (name == "bob") 
//     Console.WriteLine("Found Bob");

// else if (name == "steve") 
//     Console.WriteLine("Found Steve");

// else 
//     Console.WriteLine("Found chuck");

// int[] numbers = {4, 8, 15, 16, 23, 42};
// int total = 0;
// bool found = false;
// foreach (int number in numbers) {    total += number;

//     if (number == 42) {
//         found = true;
//     }
    
// }

// if (found) {
//     Console.WriteLine("Set contains 42");
// }

// Console.WriteLine($"Total: {total}");

// Branch the flow of code using switch-case construct in C#

// int employeeLevel = 100;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel) {

//     case 100:
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;    
// }

// Console.WriteLine($"{employeeName}, {title}");

// SKU = Stock Keeping Unit
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0]) {
//     case "01":
//         type = "Sweatshirt";
//         break;
//     case "02":
//         type = "T-shirt";
//         break;
//     case "03":
//         type = "Sweat pants";
//         break;
//     default:
//         type = "Other";
//         break;
// }

// switch (product[1]) {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color = "White";
//         break;    
// }

// switch (product[2]) {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One size fits all";
//         break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");
    
// Iterate through code block using for statement in C#

// for (int i = 0; i < 10; i++) {
//     Console.WriteLine(i);
//     if (i == 7) {
//         break;
//     }
// }

// string[] names = {"Alex", "Eddie" , "David", "Michael"};

// for (int i = 0; i < names.Length; i++) {
//     if (names[i] == "David") names[i] = "Sammy";
// }

// foreach (var name in names) {
//     Console.WriteLine(name);
// }

// FizzBuss

// for (int i = 1; i <= 100; i++) {
//     if (i % 3 == 0 && i % 5 == 0) {
//         Console.WriteLine($"{i} - FizzBuzz");
//     }
//     else if (i % 3 == 0) {
//         Console.WriteLine($"{i} - Fizz");
//     }
//     else if (i % 5 == 0) {
//         Console.WriteLine($"{i} - Buzz");
//     }
//     else {
//         Console.WriteLine(i);
//     }
// }

// Add looping logic to your code using the do-while and while statements in C#

// Random random = new Random();
// int current = random.Next(1, 11);

// do {
//     current = random.Next(1, 11);


//     if (current >= 8) {
//         continue;

//         Console.WriteLine(current); 
        
//     }
//     Console.WriteLine(current);
// } while(current != 7);

// while (current >= 3) {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

// int heroHealth = 10;
// int monsterHealth = 10;
// Random random = new Random();


// while (heroHealth > 0 && monsterHealth > 0) {

   
//     int heroDamage = random.Next(1, 11);
//     int monsterDamage = random.Next(1, 11);

//     monsterHealth -= heroDamage;
//     heroHealth -= monsterDamage;

//     Console.WriteLine($"Monster was damage and lost {heroDamage} health and now has {monsterHealth}");
//     Console.WriteLine($"Hero was damage and lost {monsterDamage} health and now has {heroHealth}");
    
    // if (heroHealth <= 0 && monsterHealth > 0) {
    //     Console.WriteLine("The hero has been defeated!");
    // }
    // else if (monsterHealth <= 0 && heroHealth > 0) {
    //     Console.WriteLine("The monster has been defeated!");
    // }
    // else if (heroHealth <= 0 && monsterHealth <= 0){
    //     Console.WriteLine("The hero and monster defeated each other!");
    //}
//}
// Console.WriteLine(heroHealth > monsterHealth ? "The Hero wins!" : "The monster wins!");

