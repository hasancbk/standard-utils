using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace StandardUtils.Helpers
{
    public static class StringHelper
    {
        public static bool IsAlphabeticalOrUnderscore(this string text)
        {
            var isAlphabetical = new Regex(@"[a-z_]+", RegexOptions.Compiled);

            var isValidated = isAlphabetical.IsMatch(text);
            return isValidated;
        }

        /// <summary>
        /// Checks if a string contains number, upper case, lower case and more than 7 character 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsValidPassword(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)
                || text.Length < 8)
            {
                return false;
            }

            var hasNumber = new Regex(@"[0-9]+", RegexOptions.Compiled);
            var hasLowerChar = new Regex(@"[a-z]+", RegexOptions.Compiled);
            var hasUpperChar = new Regex(@"[A-Z]+", RegexOptions.Compiled);

            var isValidated = hasNumber.IsMatch(text)
                              && hasUpperChar.IsMatch(text)
                              && hasLowerChar.IsMatch(text);
            return isValidated;
        }

        public static bool IsNotValidPassword(this string text)
        {
            return !IsValidPassword(text);
        }

        public static bool IsEmail(this string text)
        {
            try
            {
                var mailAddress = new MailAddress(text);
                return mailAddress.Address == text;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsNotEmail(this string text)
        {
            return !IsEmail(text);
        }

        public static bool IsEmpty(this string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }

        public static bool IsNotEmpty(this string text)
        {
            return !IsEmpty(text);
        }

        public static bool IsTrue(this string text)
        {
            text = text.TrimOrDefault();
            if (text.IsNotEmpty()
                && (text.ToLowerInvariant() == "true"
                    || text == "1"))
            {
                return true;
            }

            return false;
        }

        public static bool IsFalse(this string text)
        {
            return !IsTrue(text);
        }

        public static bool IsUrl(this string text)
        {
            var result = Uri.TryCreate(text, UriKind.Absolute, out var uriResult)
                         && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            return result;
        }

        public static bool IsNotUrl(this string text)
        {
            return !IsUrl(text);
        }

        /// <summary>
        /// Checks if a string is cron expression 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsValidCronExpression(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }
            var pattern = @"((([0-5][0-9]|[0-9])(-([0-5][0-9]|[0-9]))?,)*([0-5][0-9]|[0-9])(-([0-5][0-9]|[0-9]))?|([*]|[0-5][0-9]|[0-9])\/([0-5][0-9]|[0-9])|[?]|[*])[\s]((([0-5][0-9]|[0-9])(-([0-5][0-9]|[0-9]))?,)*([0-5][0-9]|[0-9])(-([0-5][0-9]|[0-9]))?|([*]|[0-5][0-9]|[0-9])\/([0-5][0-9]|[0-9])|[?]|[*])[\s]((([0-1][0-9]|[2][0-3]|[0-9])(-([0-1][0-9]|[2][0-3]|[0-9]))?,)*([0-1][0-9]|[2][0-3]|[0-9])(-([0-1][0-9]|[2][0-3]|[0-9]))?|([*]|[0-1][0-9]|[2][0-3]|[0-9])\/([0-1][0-9]|[2][0-3]|[0-9])|[?]|[*])[\s]((([0][1-9]|[1-2][0-9]|[3][0-1]|[1-9])(-([0][1-9]|[1-2][0-9]|[3][0-1]|[1-9]))?,)*([0][1-9]|[1-2][0-9]|[3][0-1]|[1-9])(-([0][1-9]|[1-2][0-9]|[3][0-1]|[1-9]))?C?|([0][1-9]|[1-2][0-9]|[3][0-1]|[1-9])\/([0][1-9]|[1-2][0-9]|[3][0-1]|[1-9])C?|LW|L(-([1-2][0-9]|[3][0-1]|[0-9]))?|[1-3][0-9]W|[1-9]W|[?]|[*])[\s](((0[1-9]|1[0-2]|[1-9])(-(0[1-9]|1[0-2]|[1-9]))?,)*(0[1-9]|1[0-2]|[1-9])(-(0[1-9]|1[0-2]|[1-9]))?|(0[1-9]|1[0-2]|[1-9])\/(0[1-9]|1[0-2]|[1-9])|((JAN|FEB|MAR|APR|MAY|JUN|JUL|AUG|SEP|OCT|NOV|DEC)(-(JAN|FEB|MAR|APR|MAY|JUN|JUL|AUG|SEP|OCT|NOV|DEC))?,)*(JAN|FEB|MAR|APR|MAY|JUN|JUL|AUG|SEP|OCT|NOV|DEC)(-(JAN|FEB|MAR|APR|MAY|JUN|JUL|AUG|SEP|OCT|NOV|DEC))?|(JAN|FEB|MAR|APR|MAY|JUN|JUL|AUG|SEP|OCT|NOV|DEC)\/(JAN|FEB|MAR|APR|MAY|JUN|JUL|AUG|SEP|OCT|NOV|DEC)|[?]|[*])[\s](([1-7](-[1-7])?,)*[1-7](-[1-7])?|[1-7]\/[1-7]|((MON|TUE|WED|THU|FRI|SAT|SUN)(-(MON|TUE|WED|THU|FRI|SAT|SUN))?,)*(MON|TUE|WED|THU|FRI|SAT|SUN)(-(MON|TUE|WED|THU|FRI|SAT|SUN))?C?|(MON|TUE|WED|THU|FRI|SAT|SUN)\/(MON|TUE|WED|THU|FRI|SAT|SUN)C?|([1-7]|MON|TUE|WED|THU|FRI|SAT|SUN)[#][1-7]|([1-7]|MON|TUE|WED|THU|FRI|SAT|SUN)(LW|L)?|[?]|[*])([\s]((19[7-9][0-9]|20[0-9][0-9])(-(19[7-9][0-9]|20[0-9][0-9]))?,)*(19[7-9][0-9]|20[0-9][0-9])(-(19[7-9][0-9]|20[0-9][0-9]))?|[\s](19[7-9][0-9]|20[0-9][0-9])\/(19[7-9][0-9]|20[0-9][0-9])|[\s][*])?$";

            var match = Regex.Match(text, pattern);

            return match.Success && match.Length == text.Length;
        }

        public static bool IsNotValidCronExpression(this string text)
        {
            return !IsValidCronExpression(text);
        }

        public static string TrimOrDefault(this string text)
        {
            return text == null ? string.Empty : text.Trim();
        }

        public static string CleanWhitespaces(this string text)
        {
            return Regex.Replace(text, @"\s+", "");
        }
    }
}