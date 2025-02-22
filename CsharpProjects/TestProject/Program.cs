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

// Code Project 1 - write code that validates integer output

// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a number between 5 and 10.");

// do{
//     readResult = Console.ReadLine();
//     if (readResult != null && int.TryParse(readResult, out int number) && number >= 5 && number <= 10) {
//         validEntry = true;
//         Console.WriteLine($"You entered {number}.");
//     } else if(!int.TryParse(readResult, out _)) {
//         Console.WriteLine("You did not enter a number.");
//     } else if (!validEntry) {
//         Console.WriteLine("Invalid entry. Please enter a number between 5 and 10.");
//     }

// }while (validEntry == false);

// Code Project 2 - write code that validates string input

// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

// do {
//     readResult = Console.ReadLine();

//     if (readResult != null) {
//         string trimmedInput = readResult.Trim().ToLower();

//         if(trimmedInput == "administrator" || trimmedInput == "manager" || trimmedInput == "user") {
//             validEntry = true;
//             switch(trimmedInput) {
//                 case "administrator":
//                     Console.WriteLine($"Your input value ({readResult}) is valid.");
//                     break;
//                 case "manager":
//                     Console.WriteLine($"Your input value({readResult}) is valid.");
//                     break;
//                 default:
//                     Console.WriteLine($"You don't have the enough access!");
//                     break;
//             } 
//         } else {
//             Console.WriteLine("Invalid entry. Please enter a valid role name (administrator, manager, or user).");
//         }

//     }
// } while(validEntry == false);

// Code Project 3 - Write code that process the contents of a string array

// string[] myStrings = new string[2] {
//     "I like pizza. I like roast chicken. I like salad",
//     "I like all three of the menu choices"
// };

// // Outer loop: Process each string in the array
// foreach (string originalString in myStrings) {

//     string myString = originalString; // Copy the original string
//     int periodLocation = myString.IndexOf("."); // find the first period

//     // Inner Loop: Process sentence if period exits
//     while(periodLocation != -1) {
//         // Extract the sentence up to the period (without the period)
//         string sentence = myString.Substring(0, periodLocation).TrimStart();
        
//         // Display the extracted sentence
//         Console.WriteLine(sentence);

//         // Remove the processed sentence, including the period
//         myString = myString.Remove(0, periodLocation + 1);

//         // Find the next period
//         periodLocation = myString.IndexOf(".");
//     }

//     // Display the last part of the string if there's no period at the end
//     if(!string.IsNullOrWhiteSpace(myString)) {
//         Console.WriteLine(myString.TrimStart());
//     }
// }

// Work with variable data in C# console applications (Part 4)

// Console.WriteLine("Signed integral types: ");

// Console.WriteLine($"sbyte: {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short: {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int: {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long: {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte: {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort: {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint: {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong: {ulong.MinValue} to {ulong.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue}");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue}");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue}");

// int[] data = new int[3];

// string shortenedString = "Hello World!";
// Console.WriteLine(shortenedString);

// int val_A = 2;
// int val_B = val_A;
// val_B = 5;

// Console.WriteLine("--Value Types--");
// Console.WriteLine($"val_A: {val_A}");
// Console.WriteLine($"val_B: {val_B}");   

// int[] ref_A = new int[1];
// ref_A[0] = 2;
// int[] ref_B = ref_A;
// ref_B[0] = 5;

// Console.WriteLine("--Reference Types--");
// Console.WriteLine($"ref_A[0]: {ref_A[0]}");
// Console.WriteLine($"ref_B[0]: {ref_B[0]}");

// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float: {myFloat}");

// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);

// string value = "bad";
// int result = 0;

// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement");
// }

// if (result > 0)
// {
//     Console.WriteLine($"Measurement (w/ offset): {50 + result}");
// }

// string[] values = {"12.3", "45", "ABC", "11", "DEF"};
// string message = "";
// decimal total = 0;
// decimal result;


// for (int i = 0; i < values.Length; i++)
// {
//     if (decimal.TryParse(values[i], out result))
//     {
        
//         total += result;
//     }
//     else 
//     {
//         message += values[i];
//     }
// }
// Console.WriteLine($"Total: {total}");
// Console.WriteLine($"Message: {message}");

// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// int result = Convert.ToInt32(value1 / value2);
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result}");

// decimal result1 = Convert.ToDecimal(value2 / (decimal)value3);
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result1}"); 

// float result2 = (value3 / (float)value1);
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result2}");


// Perform operations on arrays using helper methods in C#

string[] pallets = [
    "B14",
    "A11",
    "B12",
    "A13"
];

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach(var pallet in pallets) {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach(var pallet in pallets) {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
 
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach(var pallet in pallets) {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing to 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets) {
//     Console.WriteLine($"--{pallet}");
// }


// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing to 3 ... count: {pallets.Length}");

// foreach(var pallet in pallets) {
//     Console.WriteLine($"--{pallet}");
// }

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",",valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items) {
//     Console.WriteLine(item);
// }

// string pangram = "The quick brown fox jumps over the lazy dog";

// char[] valueArray = pangram.ToCharArray();
// Array.Reverse(valueArray);
// string result = new string(valueArray);

// Console.WriteLine(result);

// Step 1
// string[] message = pangram.Split(" ");

// Step 2
// string[] newMessage = new string[message.Length];

// Step 3
// for (int i = 0; i < message.Length; i++) {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);
// }

// Step 4
// string result = String.Join(" ",newMessage);
// Console.WriteLine(result);


// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// string[] orders = orderStream.Split(",");

// string[] checkOrderStream = new string [orders.Length];

// for (int i = 0; i < orders.Length; i++) {
//     char[] letters = orders[i].ToCharArray();
// Array.Sort(orders);
//     checkOrderStream[i] = new string(letters);
// }

// foreach(var order in orders) {
//     if (order.Length == 4) {
//         Console.WriteLine(order);
//     }
//     else {
//         Console.WriteLine($"{order}\t--Error");
//     }
// }


// Work with variable data in C# console applications

// string first = "Hello";
// string second = "World";

// string result = string.Format("{0} {1}", first, second);
// Console.WriteLine($"{first} {second}");
// Console.WriteLine($"{second} {first}");
// Console.WriteLine($"{first}, {first}, {first}");

// decimal price = 123.45m;
// int discount = 50;

// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N4} units");

// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");

// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular price {1:C2} price.", (price - salePrice), price);
// yourDiscount += $" A discount of {((price - salePrice) / price):P2}!"; // inserted
// Console.WriteLine(yourDiscount);

// int invoiceNumber = 1201;
// decimal productShares = 25.45678m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"   Shares: {productShares:N3} Product");
// Console.WriteLine($"     Sub Total: {subtotal:C3}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");
// Console.WriteLine($"     Total Billed: {total:C}");

// string input = "Pad this";
// Console.WriteLine(input.PadRight(12));

// Console.WriteLine(input.PadLeft(12,'-'));
// Console.WriteLine(input.PadRight(12, '-'));

// string paymentId = "769c";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";

// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);

// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);

// string name = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// // Your Logic here
// Console.WriteLine("");
// Console.WriteLine($"Dear {name},\n");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
// Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}\n");
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C2}\n");
// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";

// // Your Logic here

// comparisonMessage += $"{currentProduct.PadRight(20)}";
// comparisonMessage += $"{currentReturn:P2}".PadRight(10);
// comparisonMessage += $"{currentProfit:C2}".PadRight(14);
// comparisonMessage += "\n";
// comparisonMessage += $"{newProduct.PadRight(20)}";
// comparisonMessage += $"{newReturn:P2}".PadRight(10);
// comparisonMessage += $"{newProfit:C2}".PadRight(14);
// Console.WriteLine(comparisonMessage);

// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// // Console.WriteLine(openingPosition);
// // Console.WriteLine(closingPosition);

// openingPosition += 1;

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length)); 

// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += 6;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "hello there!";

// int first_h = message.IndexOf('h');
// int last_h = message.LastIndexOf('h');

// Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at {last_h}.");


// string message = "(What if) I am (only interested) in the last (set of parentheses)?";

// while(true)
// {   
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;

//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining
    // unprocessed message:

//     message = message.Substring(closingPosition + 1); 
// }

// string message = "Hello world!";
// char[] charsToFind = {'a', 'e', 'i'};

// int index = message.IndexOfAny(charsToFind);

// Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");

// string message = "Help (find) the {opening symbols}";
// Console.WriteLine($"Searching THIS message: {message}");
// char[] openSymbols = {'[', '{', '('};
// int startPosition = 5;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}");

// string message = "(What if) i have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// // The IndexOfAny() helper method requires a char array of characters.
// // You want to look for:

// char[] openSymbols = {'[', '{', '('};

// int closingPosition = 0;

// while(true) {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1) {
//         break;
//     }

//     string currentSymbol = message.Substring(openingPosition, 1);

//     // Now find the matching closing symbol
//     char matchingSymbol = ' ';

//     switch(currentSymbol) {

//         case "[":
//             matchingSymbol = ']';
//             break;

//         case "{":
//             matchingSymbol = '}';
//             break;

//         case "(":
//             matchingSymbol = ')';
//             break;
//     }

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }

// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5,20);
// Console.WriteLine(updatedData);

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
int start = input.IndexOf("<span>") + 6;
int end = input.IndexOf("</span>" , start);

quantity = "Quantity: " + input.Substring(start, end - start);
Console.WriteLine(quantity);

output = input.Replace("&trade", "&reg")
              .Replace("<div>", "")
              .Replace("</div>", "");
Console.WriteLine(output);