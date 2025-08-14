// Fix type conversion errors

// Initial state
// var varValue = 100;
// short shortValue;
// sbyte sbyteValue;
// ushort ushortValue;
// long longValue;
// longValue = varValue;
// sbyteValue = varValue;
// ushortValue = sbyteValue;
// shortValue = ushortValue;

// Solution
// var varValue = 100;
// short shortValue;
// sbyte sbyteValue;
// ushort ushortValue;
// long longValue;
// longValue = varValue;
// sbyteValue = (sbyte)varValue;
// ushortValue = (ushort)sbyteValue;
// shortValue = (short)ushortValue;

// Initial state
// long longValue = 100;
// var varValue = 100.0;
// float floatValue;
// double doubleValue;
// decimal decimalValue;
// longValue = varValue;
// floatValue = varValue;
// doubleValue = varValue;
// decimalValue = varValue;
// doubleValue = decimalValue;
// decimalValue = longValue;

// Solution
// long longValue = 100;
// var varValue = 100.0;
// float floatValue;
// double doubleValue;
// decimal decimalValue;

// longValue = (long)varValue;
// floatValue = (float)varValue;
// doubleValue = varValue;
// decimalValue = (decimal)varValue;
// doubleValue = (double)decimalValue;
// decimalValue = longValue;

// Char conversions
// Convert bigLetter to lower case, smallLetter - to upper case
// Why is there no error in value1, value2, value3, value4 declarations? Print these variables

// Solution
char bigLetter = 'Я';
char smallLetter = 'z';
int value1 = 0x3A6; // hexadecimal integer
ushort value2 = '\u0824'; // it's a char that's initialized with aunicode escape sequence, it represents a number, hence there's no error
long value3 = 10574; // long can fit int numbers, and that's why we don't need to use casting
int value4 = '\x25A3'; // it's a char that's initialized with hexadecimal escape sequence, it represents a number, hence there's no error

char bigLetterLowerCase = Char.ToLower(bigLetter);
Console.WriteLine(bigLetterLowerCase);

char smallLetterUpperCase = Char.ToUpper(smallLetter);
Console.WriteLine(smallLetterUpperCase);

Console.WriteLine(value1);
Console.WriteLine(value2);
Console.WriteLine(value3);
Console.WriteLine(value4);

// Make a single string from these three variables, each word must be on a separate line
string first = "Меня";
string second = "зовут";
string? third = Console.ReadLine();

Console.WriteLine(@$"{first}
{second}
{third}");
// Составьте из трёх строк одну строку таким образом,
// чтобы каждое слово было на новой строке.
// Используйте все варианты изученные нами на теоретическом уроке
// Сколько способов вы нашли?