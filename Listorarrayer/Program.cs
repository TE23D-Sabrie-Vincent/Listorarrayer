// List<string> bois = ["Woody", "Buzz Lightyear", "Mr. Potato", "Tågleksak", "Docka"];

// for (int i = 0; i < bois.Count; i++)
// {
//    System.Console.WriteLine($"{bois [i]}"); 
// }

// List<string> klasskamrater = ["Simon", "Theodor", "Richard", "Konstantin", "Kevin"];

// List<string> klasskamrater = ["Simon", "Theodor", "Richard", "Konstantin", "Kevin"];

// List<string> leksaker = ["Woody", "Buzz Lightyear", "Mr. Potato", "Tågleksak", "Docka"];

// List<string> nummer = ["1", "3", "5", "7", "9"];

// // for (int i = 0; i < nummer.Count; i++)
// // {
// //     nummer[i] = Random.Shared.Next(1, 10).ToString();
// // }
// // Ignorerar Random nummer på betyget, jag fick hjälp med det

// for (int i = 0; i < klasskamrater.Count; i++)
// {
//     System.Console.WriteLine($"{klasskamrater[i]} ger {leksaker[i]} betyget {nummer[i]}");
// }

List<string> cities = [];


while (true)
{
    System.Console.WriteLine("Skriv vad du vill lägga till i listan");
    string input = Console.ReadLine();
    if (input == "exit")
    {
        break;
    }
    cities.Add(input);

}
