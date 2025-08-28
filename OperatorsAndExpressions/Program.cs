// 1. Change equality operators to make WriteLine calls print true
// int a = 10;
// int b = 100;
// int c = 1000;
// Console.WriteLine(a == b && b == a);
// Console.WriteLine(c == a && a == c);

// // Solution
// Console.WriteLine(a != b && b != a);
// Console.WriteLine(c > a && a < c);

// // The task is the same but it's not allowed to change the logical or comparison operators
// Console.WriteLine(b > c && c < a);

// // Solution
// Console.WriteLine(!(b > c && c < a));


// 2. Update the next line and if-else code blocks in methods to print “X equals Y”, “X is greater than Y”, “X is less than Y”
// bool result = FirstEqualsSecond(10, 10) || FirstGreaterSecond(3, 2) || FirstLessSecond(2, 3);
// bool FirstEqualsSecond(int x, int y)
// {
//   if (x != y) { Console.WriteLine("X equals Y"); }
//   else { Console.WriteLine("X doesn't equal Y"); }
//   return x == y;
// }
// bool FirstGreaterSecond(int x, int y)
// {
//   if (x == y) { Console.WriteLine("X is greater than Y"); }
//   else { Console.WriteLine("X is less than or equals Y"); }
//   return x > y;
// }
// bool FirstLessSecond(int x, int y)
// {
//   if (x == y) { Console.WriteLine("X is less than Y"); }
//   else { Console.WriteLine("X is greater than or equals Y"); }
//   return x < y;
// }

// Solution
// bool result = FirstEqualsSecond(10, 10) | FirstGreaterSecond(3, 2) | FirstLessSecond(2, 3);
// bool FirstEqualsSecond(int x, int y)
// {
//   if (x == y) { Console.WriteLine("X equals Y"); }
//   else { Console.WriteLine("X doesn't equal Y"); }
//   return x == y;
// }
// bool FirstGreaterSecond(int x, int y)
// {
//   if (x > y) { Console.WriteLine("X is greater than Y"); }
//   else { Console.WriteLine("X is less than or equals Y"); }
//   return x > y;
// }
// bool FirstLessSecond(int x, int y)
// {
//   if (x < y) { Console.WriteLine("X is less than Y"); }
//   else { Console.WriteLine("X is greater than or equals Y"); }
//   return x < y;
// }

// int points = 1;
// switch (points)
// {
//   case 1:
//     Console.WriteLine("You have 1 point, this is not good!");
//     goto default; // or any other EXISTING case, eg goto 10 will work, whereas goto 222 won't work
//   case 10:
//     Console.WriteLine("You have 10 points, that's a new record");
//     break;
//   default:
//     Console.WriteLine("You've passed!");
//     break;
// }

// object someValue = "111";
// switch (someValue)
// {
//   case int x:
//     Console.WriteLine($"That's a number {x}!");
//     break;
//   case string message when message == "Hello":
//     Console.WriteLine($"That's a string {message}");
//     break;
//   default:
//     Console.WriteLine("That's something else...");
//     break;
// }

// int temperature = 25;
// string feelsLike = temperature switch
// {
//   < 10 => "Cold",
//   < 15 => "Chilly",
//   < 20 => "Warm",
//   < 30 => "Hot",
//   _ => "Unbearably hot"
// };
// Console.WriteLine(feelsLike);

int temperature = 25;
bool isWindy = false;
string feelsLike = (temperature, isWindy) switch
{
  (15, false) => "Cold",
  (15, true) => "Chilly",
  (20, false) => "Warm",
  (20, true) => "Not so warm",
  _ => "Something else.."
};
Console.WriteLine(feelsLike);

// 3. Update the switch operator to get card's name by the value, where 6 - 10 map to 'A simple card',
// 14 maps to ace, 13 to king, 12 - queen, 11 - jack
// Random rnd = new();
// int value = rnd.Next(6, 15);
// switch (value)
// {
// }

Random random = new();
int value = random.Next(6, 15);
string cardName = (value) switch
{
  11 => "Jack",
  12 => "Quenn",
  13 => "King",
  14 => "Ace",
  _ => "A simple card"
};

Console.WriteLine(cardName);

// 4. Finish the function that's based on the switch operator that prints the type of the passed value
PrintTheType("S");
PrintTheType(2.0F);
PrintTheType(10.2M);
PrintTheType(11L);
PrintTheType('A');
void PrintTheType(object value)
{
  switch (value)
  {
    case string text:
      Console.WriteLine($"That's a string: {text}");
      break;
    case float floatingPointTypeNumber:
      Console.WriteLine($"That's a floating-type number: {floatingPointTypeNumber}");
      break;
    case long longTypeNumber:
      Console.WriteLine($"That's a very long number: {longTypeNumber}");
      break;
    case decimal decimalTypeNumber:
      Console.WriteLine($"That's a decimal type: {decimalTypeNumber}");
      break;
    default:
      Console.WriteLine($"I have no clue what this might be...");
      break;
  }
}





