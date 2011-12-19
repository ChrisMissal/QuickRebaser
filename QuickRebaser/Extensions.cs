using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace QuickRebaser
{
    [DebuggerStepThrough]
    public static class StringExtensions
    {
        public static LineType ToLineType(this string @this)
        {
            if (@this.IsNullOrEmpty())
                return LineType.Unknown;

            switch (@this.ToUpper())
            {
                case "F":
                    return LineType.Fixup;
                case "R":
                    return LineType.Reword;
                case "E":
                    return LineType.Edit;
                case "S":
                    return LineType.Squash;
                case "P":
                    return LineType.Pick;
                default:
                    return LineType.Unknown;
            }
        }

        public static string FormatWith(this string @this, params object[] args)
        {
            return string.Format(@this, args);
        }

        public static string SubstringAfter(this string @this, char delimiter, int occurence = 1)
        {
            var strings = @this.Split(new[] {delimiter}, StringSplitOptions.None);
            if (strings.Length <= occurence)
                return "";

            var requested = strings[occurence];

            return requested.IsNullOrEmpty() ? requested : @this.Substring(@this.IndexOf(requested));
        }

        public static bool IsNullOrEmpty(this string @this)
        {
            return string.IsNullOrEmpty(@this);
        }
    }

    [DebuggerStepThrough]
    public static class EnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> @this, Action<T> action)
        {
            foreach (var item in @this)
                action(item);
        }
    }
}