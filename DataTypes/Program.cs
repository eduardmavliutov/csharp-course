// Fix type conversion errors

// var varValue = 100;
// short shortValue;
// sbyte sbyteValue;
// ushort ushortValue;
// long longValue;
// longValue = varValue;
// sbyteValue = varValue;
// ushortValue = sbyteValue;
// shortValue = ushortValue;

var varValue = 100;
short shortValue;
sbyte sbyteValue;
ushort ushortValue;
long longValue;
longValue = varValue;
sbyteValue = (sbyte)varValue;
ushortValue = (ushort)sbyteValue;
shortValue = (short)ushortValue;

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

long longValue = 100;
var varValue = 100.0;
float floatValue;
double doubleValue;
decimal decimalValue;

longValue = (long)varValue;
floatValue = (float)varValue;
doubleValue = varValue;
decimalValue = (decimal)varValue;
doubleValue = (double)decimalValue;
decimalValue = longValue;


