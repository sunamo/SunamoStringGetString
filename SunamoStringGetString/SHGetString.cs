namespace SunamoStringGetString;

/// <summary>
/// Provides helper methods for converting string collections into a single string.
/// </summary>
public class SHGetString
{
    /// <summary>
    /// Concatenates all strings in the list into a single string without any delimiter.
    /// </summary>
    /// <param name="list">The list of strings to concatenate.</param>
    /// <returns>A single concatenated string.</returns>
    public static string GetString(List<string> list)
    {
        var stringBuilder = new StringBuilder();
        foreach (var item in list) stringBuilder.Append(item);
        return stringBuilder.ToString();
    }

    /// <summary>
    /// Converts a list of strings into a single string representation, joining elements with the specified delimiter.
    /// </summary>
    /// <param name="list">The list of strings to convert. Returns "(null)" if null.</param>
    /// <param name="delimiter">The delimiter to use between elements. Defaults to <see cref="Environment.NewLine"/> if null.</param>
    /// <returns>A string representation of the list.</returns>
    public static string ListToString(List<string>? list, string? delimiter = null)
    {
        if (list == null) return "(null)";

        string text;
        var listType = list.GetType();

        if (list is IList && listType != Types.StringType && listType != Types.StringBuilderType &&
            !(list is IList<char>))
        {
            delimiter ??= Environment.NewLine;

            text = string.Join(delimiter, list);
        }
        else
        {
            text = list.ToString() ?? string.Empty;
        }

        return text;
    }
}
