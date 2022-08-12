

namespace FizzBuzzLib.Test;

public class FizzBuzzTests
{
    private Dictionary<int, string> fizzBuzzTokenDictionary = new Dictionary<int, string> { { 3, "Fizz" }, { 5, "Buzz" } };
    private Dictionary<int, string> fizzBuzzBangTokenDictionary = new Dictionary<int, string> { { 3, "Fizz" }, { 5, "Buzz" }, { 10, "Bang" } };

    [Fact]
    public void IGetFizzOn3()
    {
        var expecteResult = "Fizz-3";
        var result = FizzBuzz.DoFizzBuzz(15, fizzBuzzTokenDictionary);
        string[] resultingArray = result.ToArray();
        Assert.Equal(expecteResult, resultingArray[3 - 1]);
    }

    [Fact]
    public void IGetBuzzOn5()
    {
        var expecteResult = "Buzz-5";
        var result = FizzBuzz.DoFizzBuzz(15, fizzBuzzTokenDictionary);
        string[] resultingArray = result.ToArray();
        Assert.Equal(expecteResult, resultingArray[5 - 1]);
    }

    [Fact]
    public void IGetTheNumberWhenNot3Or5()
    {
        var expecteResult = "2";
        var result = FizzBuzz.DoFizzBuzz(15, fizzBuzzTokenDictionary);
        string[] resultingArray = result.ToArray();
        Assert.Equal(expecteResult, resultingArray[2 - 1]);
    }

    [Fact]
    public void IGetFizzBuzzOn15()
    {
        var expecteResult = "FizzBuzz-15";
        var result = FizzBuzz.DoFizzBuzz(15, fizzBuzzTokenDictionary);
        string[] resultingArray = result.ToArray();
        Assert.Equal(expecteResult, resultingArray[15 - 1]);
    }

    [Fact]
    public void IGetBuzzBangOn10()
    {
        var expecteResult = "BuzzBang-10";
        var result = FizzBuzz.DoFizzBuzz(15, fizzBuzzBangTokenDictionary);
        string[] resultingArray = result.ToArray();
        Assert.Equal(expecteResult, resultingArray[10 - 1]);
    }

    [Fact]
    public void IGetFizzBuzzBangOn30()
    {
        var expecteResult = "FizzBuzzBang-30";
        var result = FizzBuzz.DoFizzBuzz(30, fizzBuzzBangTokenDictionary);
        string[] resultingArray = result.ToArray();
        Assert.Equal(expecteResult, resultingArray[30 - 1]);
    }
}
