// String filtering
string[] words = ["Bosch", "Mexico", "Mango", "Mark", "Blr", "Clean code"];

bool FilterWith(string word, string c) => word.StartsWith(c, StringComparison.OrdinalIgnoreCase);

var filteredStrings = Filter(words, s => FilterWith(s, "M"));

foreach (string w in filteredStrings)
{
	Console.WriteLine(w);
}

// Integer filtering
var numbers = new[] { 1, 2, 3, 4, 5, 6 };

bool IsEven(int n) => n % 2 == 0;

var filteredInts = Filter(numbers, IsEven);

foreach (int i in filteredInts)
{
	Console.WriteLine(i);
}

List<T> Filter<T>(IEnumerable<T> items, Func<T, bool> predicate)
{
	var result = new List<T>();
	foreach (var item in items)
	{
		if (predicate(item))
			result.Add(item);
	}

	return result;
}
