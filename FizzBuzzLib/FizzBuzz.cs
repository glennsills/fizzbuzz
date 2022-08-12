namespace FizzBuzzLib;

public class FizzBuzz
{
    public static IEnumerable<string> DoFizzBuzz(int maximumNumber, Dictionary<int, string> numberTokens)
    {
        var output = new List<string>();
        for (int i = 1; i <= maximumNumber; ++i)
        {
            List<string> tokens = new List<string>();
            foreach(int key in numberTokens.Keys)
            {
                if (i % key == 0 ) tokens.Add($"{numberTokens[key]}");
            }
            if (tokens.Any())
            {
                yield return String.Join("", tokens) + ($"-{i}");
            }
             else
            {
                yield return i.ToString();
            }
        }
    }
}
