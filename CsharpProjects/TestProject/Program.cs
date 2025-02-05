// // // See https://aka.ms/new-console-template for more information
// // // Console.WriteLine("Hello, C#!");

// // // Call methods from the .NET Class Library using C#endregion

// // // Random dice = new Random();
// // // int roll = dice.Next(1, 7);
// // // Console.WriteLine(roll);

// // // int number = 7;
// // // string text = "seven";


// // // Console.WriteLine(number);
// // // Console.WriteLine();
// // // Console.WriteLine(text);

// // // Random dice = new Random();
// // // int roll1 = dice.Next();
// // // int roll2 = dice.Next(101);
// // // int roll3 = dice.Next(50, 101);

// // // Console.WriteLine($"First roll: {roll1}");
// // // Console.WriteLine($"Second roll: {roll2}");
// // // Console.WriteLine($"Third roll: {roll3}");

// // // int firstValue = 500;
// // // int secondValue = 600;
// // // int largerValue = Math.Max(firstValue, secondValue);

// // // Console.WriteLine(largerValue);

// // // Add decision logic to your code using 'if', 'else if', and 'else' statements in C#.

// // Random dice = new Random();

// // // int roll1 = dice.Next(1, 7);
// // // int roll2 = dice.Next(1, 7);
// // // int roll3 = dice.Next(1, 7);

// // int roll1 = 1;
// // int roll2 = 4;
// // int roll3 = 1;

// // int total = roll1 + roll2 + roll3;

// // Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// // if((roll1 == roll2 || (roll2 == roll3) || (roll1 == roll3))) {
// //     if((roll1 == roll2) && (roll2 == roll3)) {
// //         Console.WriteLine("You rolled triples! +6 bonus to total!");
// //         total += 6;
// //     }
// //     else {
// //         Console.WriteLine("You rolled doubles! +2 bonus to total!");
// //         total += 2;
// //     }
// //     Console.WriteLine($"Your total including the bonus: {total}");
// // }



// // if (total >= 16) {
// //     Console.WriteLine("You win a new car!");  
// // }
// // else if (total >= 10)
// // {
// //     Console.WriteLine("You win a new laptop!");
// // }
// // else if (total == 7) 
// // {
// //     Console.WriteLine("You win a trip for two!");
// // }
// // else {
// //     Console.WriteLine("You win a kitten!");
// // }

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// // Your code goes here

// if (daysUntilExpiration == 0){
//     Console.WriteLine("Your subscription has expired");
// }
// else if (daysUntilExpiration == 1) {
//     Console.WriteLine("Your subscription expires within a day!\nRenew now and save 20%!");
//     discountPercentage = 20;
// }
// else if (daysUntilExpiration <= 5) {
//     Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days.\nRenew now and save 10%!");
//     discountPercentage = 10;
// }
// else if (daysUntilExpiration <= 10) {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

// if (discountPercentage > 0) {
//     Console.WriteLine($"Renew now and save {discountPercentage}%.");
// }

// Store and iterate through sequence of data using Arrays and the foreach statement in C#

// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

// string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// int[] inventory = {200, 450, 700, 175, 250};
// int sum = 0;
// int bin = 0;

// foreach (int items in inventory) {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }

// Console.WriteLine($"We have {sum} items in inventory.");

// string[] fraudulentOrderIDs = ["B123", "C234", "A345", "C15", "B177", "G3001", "C235", "B179"];

// foreach (string orderID in fraudulentOrderIDs) {
//     if (orderID.StartsWith("B")) {
//         Console.WriteLine("Canceling order " + orderID + " (B)");
//     } else if (orderID.StartsWith("C")) {
//         Console.WriteLine("Contact customer about order " + orderID + " (C)");
//     } else {
//         Console.WriteLine("Order " + orderID + " requires no action.");
//     }
// }