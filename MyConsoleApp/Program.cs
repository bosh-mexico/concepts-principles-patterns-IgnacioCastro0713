// See https://aka.ms/new-console-template for more information
string[] words = ["Bosch", "Mexico", "Mango", "Mark", "Blr", "Clean code"];

var result = FilterString(words, word => word.StartsWith('M'));

foreach (string w in result)
{
	Console.WriteLine(w);
}

return;

List<string> FilterString(string[] strings, Func<string, bool> predicate)
{
	return strings.Where(predicate).ToList();
}