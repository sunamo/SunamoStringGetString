namespace SunamoStringGetString;

/// <summary>
/// Represents the SH get string type.
/// </summary>
public class SHGetString
{
    /// <summary>
    /// Get string.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <returns>The get string result.</returns>
    public static string GetString(List<string> list)
    {
        var stringBuilder = new StringBuilder();
        foreach (var item in list) stringBuilder.Append(item);
        return stringBuilder.ToString();
    }

    /// <summary>
    /// List to string.
    /// </summary>
    /// <param name="list">The list.</param>
    /// <param name="delimiter">The delimiter.</param>
    /// <returns>The list to string result.</returns>
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
