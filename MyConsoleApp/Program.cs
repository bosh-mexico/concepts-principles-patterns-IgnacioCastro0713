// See https://aka.ms/new-console-template for more information
string[] words = ["Bosch", "Mexico", "Mango", "Mark", "Blr", "Clean code"];

var result = words
	.Where(word => word.StartsWith('M'))
	.ToArray();

foreach (string w in result)
{
	Console.WriteLine(w);
}
