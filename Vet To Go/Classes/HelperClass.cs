using System;
using System.Data.SqlClient;

namespace Vet_To_Go.Classes
{
    /// <summary>
    /// Static class with various re-useable tools
    /// </summary>
    public static class HelperClass
    {
        /// <summary>
        /// Capitalizes first letter, makes rest of word lowercase
        /// </summary>
        public static String GetCapitalizedString(String input)
        {
            return System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }

        /// <summary>
        /// Ensures a string is returned in order to skip over (fill) null values
        /// </summary>
        public static String GetNotNullString(SqlDataReader reader, int columnIndex)
        {
            if (!reader.IsDBNull(columnIndex))
            {
                return reader.GetString(columnIndex);
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// Displays date in the following format: 1/1/2000
        /// </summary>
        public static String FormatDate(DateTime date)
        {
            return String.Format("{0:d}", date);
        }

        /// <summary>
        /// Displays date in the following format: 01/01/2000, used for masked textboxes
        /// </summary>
        public static string FormatDateAsMMDDYYYY(DateTime date)
        {
            string result = "";
            result = date.Month.ToString().Trim().PadLeft(2, '0');
            result += date.Day.ToString().Trim().PadLeft(2, '0');
            result += date.Year.ToString().Trim();

            return result;
        }

        /// <summary>
        /// Returns a string formatted as "0.##"
        /// </summary>
        public static String FormatMoney(decimal money)
        {
            return money.ToString("0.##");
        }

        /// <summary>
        /// Returns a string containing information required to connect to the Azure database
        /// </summary>
        public static String GetConnectionString()
        {
            return "Server=tcp:vet-to-go.database.windows.net,1433;Initial Catalog=Vet To Go DB;Persist Security Info=False;User ID=vetsqladmin;Password=VetPassword!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }
    }
}