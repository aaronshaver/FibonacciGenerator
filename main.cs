// prints Fibonacci numbers

var previousNumber = 0;
var nextNumber = 1;
int currentNumber;
Console.WriteLine(previousNumber);
do {
	Console.WriteLine(nextNumber);
	currentNumber = nextNumber;
	nextNumber += previousNumber;
	previousNumber = currentNumber;
} while (nextNumber < 40);