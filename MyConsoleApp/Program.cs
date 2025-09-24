// See https://aka.ms/new-console-template for more information
string[] words = ["Bosch", "Mexico", "Mango", "Mark", "Blr", "Clean code"];

bool FilterWithM(string word) => word.StartsWith("M", StringComparison.OrdinalIgnoreCase);

var result = FilterString(words, FilterWithM);

foreach (string w in result)
{
	Console.WriteLine(w);
}


List<string> FilterString(string[] strings, Func<string, bool> predicate)
{
	var filterString = new List<string>();
	foreach (var s in strings)
	{
		if (predicate(s))
		{
			filterString.Add(s);
		}
	}

	return filterString;
}
