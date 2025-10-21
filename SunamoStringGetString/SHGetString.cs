// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy

namespace SunamoStringGetString;

public class SHGetString
{
    public static string GetString(List<string> o/*, string p*/)
    {
        //StringBuilder stringBuilder = new StringBuilder();
        //foreach (var item in o)
        //{
        //    stringBuilder.Append(ListToString(item, p) + p);
        //}
        //return stringBuilder.ToString();

        var stringBuilder = new StringBuilder();
        foreach (var item in o) stringBuilder.Append(item);
        return stringBuilder.ToString();
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