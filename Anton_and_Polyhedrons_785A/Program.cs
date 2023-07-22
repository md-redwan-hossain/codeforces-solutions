var total = int.Parse(Console.ReadLine()!);
var result = 0;

var dict = new Dictionary<string, int>()
{
    { "Tetrahedron", 4 },
    { "Cube", 6 },
    { "Octahedron", 8 },
    { "Dodecahedron", 12 },
    { "Icosahedron", 20 }
};


for (var i = 0; i < total; i++)
{
    var input = Console.ReadLine()!;
    if (dict.TryGetValue(input, out var value)) result += value;
}

Console.WriteLine(result);