using AOC2022;


List<Elf> elves = new List<Elf>();
Elf elf = new Elf();
foreach (string calorie in File.ReadAllLines("day1.txt"))
{
    if (string.IsNullOrEmpty(calorie))
    {
        elf.TotalCalories = elf.Calories.Sum();
        elves.Add(elf);
        elf = new Elf();
    }
    else
    {

        elf.Calories.Add(int.Parse(calorie));
    }
}

var highestCalories = elves.Max(t => t.TotalCalories);
var sortElvesDescending = elves.OrderByDescending(c => c.TotalCalories).ToList();
int topCalories3 = sortElvesDescending[0].TotalCalories + sortElvesDescending[1].TotalCalories + sortElvesDescending[2].TotalCalories;
Console.WriteLine(topCalories3);
