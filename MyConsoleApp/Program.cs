// See https://aka.ms/new-console-template for more information
string[] words = ["Bosch", "Mexico", "Mango", "Mark", "Blr", "Clean code"];

var result = new List<string>();

foreach (var word in words)
{
	if (word.StartsWith('M'))
	{
		result.Add(word);
	}
}

foreach (string w in result)
{
	Console.WriteLine(w);
}