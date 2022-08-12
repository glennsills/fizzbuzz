using FizzBuzzLib;

var tokenDictionary = new Dictionary<int, string> { { 3, "Fizz" }, { 5, "Buzz" } };

var listOfFizzBuzz = FizzBuzz.DoFizzBuzz(100, tokenDictionary);
foreach (var fizzBuzz in listOfFizzBuzz)
{
    Console.WriteLine(fizzBuzz);
}
