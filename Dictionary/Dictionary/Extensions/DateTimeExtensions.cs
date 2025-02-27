using System.Globalization;

namespace Dictionary.Extensions {
    static class DateTimeExtensions {
        public static string ElapsedTime(this DateTime thisObj) {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours <= 24) return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            if (duration.TotalHours > 24) return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Days";
            return duration.ToString();
        }
    }
}
