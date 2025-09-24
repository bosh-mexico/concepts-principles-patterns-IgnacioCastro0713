// See https://aka.ms/new-console-template for more information
string[] words = ["Bosch", "Mexico", "Mango", "Mark", "Blr", "Clean code"];

bool FilterWith(string word, string c) => word.StartsWith(c, StringComparison.OrdinalIgnoreCase);

var result = FilterString(words, s => FilterWith(s, "M"));

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
