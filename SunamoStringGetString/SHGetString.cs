namespace SunamoStringGetString;

public class SHGetString
{
    public static string GetString(List<string> list)
    {
        var stringBuilder = new StringBuilder();
        foreach (var item in list) stringBuilder.Append(item);
        return stringBuilder.ToString();
    }

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
