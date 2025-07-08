namespace SampleLibrary;

/// <summary>
/// Utility class for string manipulation operations.
/// </summary>
public static class StringUtilities
{
    /// <summary>
    /// Reverses the characters in a string.
    /// </summary>
    /// <param name="input">The string to reverse.</param>
    /// <returns>The reversed string.</returns>
    /// <exception cref="ArgumentNullException">Thrown when input is null.</exception>
    public static string Reverse(string input)
    {
        if (input == null)
        {
            throw new ArgumentNullException(nameof(input));
        }

        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    /// <summary>
    /// Counts the number of words in a string.
    /// </summary>
    /// <param name="input">The string to count words in.</param>
    /// <returns>The number of words in the string.</returns>
    public static int CountWords(string? input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        return input.Split(new char[] { ' ', '\t', '\n', '\r' },
                          StringSplitOptions.RemoveEmptyEntries).Length;
    }

    /// <summary>
    /// Capitalizes the first letter of each word in a string.
    /// </summary>
    /// <param name="input">The string to title case.</param>
    /// <returns>The title-cased string.</returns>
    public static string ToTitleCase(string? input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return string.Empty;
        }

        var words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 0)
            {
                words[i] = char.ToUpper(words[i][0]) +
                          (words[i].Length > 1 ? words[i][1..].ToLower() : "");
            }
        }

        return string.Join(" ", words);
    }
}
