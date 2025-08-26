// 1. Change equality operators to make WriteLine calls print true
int a = 10;
int b = 100;
int c = 1000;
Console.WriteLine(a == b && b == a);
Console.WriteLine(c == a && a == c);

// Solution
Console.WriteLine(a != b && b != a);
Console.WriteLine(c > a && a < c);

// The task is the same but it's not allowed to change the logical or comparison operators
Console.WriteLine(b > c && c < a);

// Solution
Console.WriteLine(!(b > c && c < a));


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
bool result = FirstEqualsSecond(10, 10) | FirstGreaterSecond(3, 2) | FirstLessSecond(2, 3);
bool FirstEqualsSecond(int x, int y)
{
  if (x == y) { Console.WriteLine("X equals Y"); }
  else { Console.WriteLine("X doesn't equal Y"); }
  return x == y;
}
bool FirstGreaterSecond(int x, int y)
{
  if (x > y) { Console.WriteLine("X is greater than Y"); }
  else { Console.WriteLine("X is less than or equals Y"); }
  return x > y;
}
bool FirstLessSecond(int x, int y)
{
  if (x < y) { Console.WriteLine("X is less than Y"); }
  else { Console.WriteLine("X is greater than or equals Y"); }
  return x < y;
}

