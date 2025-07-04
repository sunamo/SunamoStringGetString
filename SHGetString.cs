namespace SunamoStringGetString;

public class SHGetString
{
    public static string GetString(List<string> o/*, string p*/)
    {
        //StringBuilder sb = new StringBuilder();
        //foreach (var item in o)
        //{
        //    sb.Append(ListToString(item, p) + p);
        //}
        //return sb.ToString();

        var sb = new StringBuilder();
        foreach (var item in o) sb.Append(item);
        return sb.ToString();
    }

    public static string ListToString(List<string> value, string delimiter = null)
    {
        if (value == null) return "(null)";

        string text;
        var valueType = value.GetType();

        if (value is IList && valueType != Types.tString && valueType != Types.tStringBuilder &&
            !(value is IList<char>))
        {
            if (delimiter == null) delimiter = Environment.NewLine;

            var enumerable = value; //CA.ToListStringIEnumerable2((IList)value);
            // I dont know why is needed SHReplace.Replace delimiterS(,) for space
            // This setting remove , before RoutedEventArgs etc.
            //CA.SHReplace.Replace(enumerable, delimiterS, "");
            text = string.Join(delimiter, enumerable);
        }
        //else if (valueType == Types.tDateTime)
        //{
        //    //DTHelperEn.ToString(
        //    text = ((DateTime)value).ToLongTimeString();
        //}
        else
        {
            text = value.ToString();
        }

        return text;
    }
}