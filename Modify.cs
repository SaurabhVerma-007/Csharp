const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

// Extract the "quantity"
const string openspan = "<span>";
const string closespan = "</span>";

int quantityStart = input.IndexOf(openspan) + openspan.Length;
int quantityEnd = input.IndexOf(closespan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

// set output to input, replacing the trademark symbol with the registered symbol
const string trademark = "&trade;";
const string registered = "&reg;";
output = input.Replace(trademark, registered);

// remove the opening <div> tag
const string opendiv = "<div>";
int divStart = output.IndexOf(opendiv);
output = output.Remove(divStart, opendiv.Length);

// remove the closing </div> tag
const string closediv = "</div>";
int divEnd = output.IndexOf(closediv);
output = "Output: " + output.Remove(divEnd, closediv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);