string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");

Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P2}\n");

Console.WriteLine($"Our new product, {newProduct}, offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}\n");
// Your logic here

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += string.Format("{0:P2}", currentReturn).PadLeft(20);
comparisonMessage += string.Format("{0:C}", currentProfit).PadLeft(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += string.Format("{0:P2}", newReturn).PadLeft(20);
comparisonMessage += string.Format("{0:C}", newProfit).PadLeft(20);

Console.WriteLine(comparisonMessage);