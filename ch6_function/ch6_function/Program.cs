using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

#region 1.
/*namespace ch6_function
{
    public class TextConverter // 定義一個名為TextConverter的類別
    {
        public static string ConvertToHtml(string input) // 定義一個靜態方法，將輸入字串轉換為HTML格式
        {
            if (string.IsNullOrEmpty(input)) // 檢查輸入是否為空或null
            {
                return string.Empty; // 如果是，返回空字串
            }

            // 使用正規表達式替換特定字元為HTML實體
            input = Regex.Replace(input, ">", "&gt;"); // 將 '>' 替換為 '&gt;'
            input = Regex.Replace(input, "<", "&lt;"); // 將 '<' 替換為 '&lt;'
            input = Regex.Replace(input, @"\r\n", "<br>"); // 將 '\r\n' 替換為 '<br>'
            input = Regex.Replace(input, @"\|", "&brvbar;"); // 將 '|' 替換為 '&brvbar;'
            input = Regex.Replace(input, " ", "&nbsp;"); // 將空白替換為 '&nbsp;'

            return input; // 返回轉換後的字串
        }
    }

    // 測試函式
    public class Program // 定義一個名為Program的類別
    {
        public static void Main() // 主方法，程式執行的入口點
        {
            string input = "Hello > World < Test\r\nNew Line | Space "; // 定義一個測試字串
            string output = TextConverter.ConvertToHtml(input); // 呼叫ConvertToHtml方法，轉換字串
            Console.WriteLine(output); // 輸出轉換後的字串
            Console.ReadKey();
        }
    }
}*/
#endregion

#region 2.
/*namespace ch6_function
{
    public class NumberChecker // 定義一個名為NumberChecker的類別
    {
        public static bool IsNumeric(string input) // 定義一個靜態方法，檢查輸入是否為數字
        {
            if (string.IsNullOrEmpty(input)) // 檢查輸入是否為空或null
            {
                return false; // 如果是，返回false
            }

            // 使用正規表達式檢查輸入是否為數字
            return Regex.IsMatch(input, @"^\d+$"); // 如果輸入符合數字格式，返回true，否則返回false
        }
    }

    // 測試函式
    public class Program // 定義一個名為Program的類別
    {
        public static void Main() // 主方法，程式執行的入口點
        {
            Console.WriteLine("請輸入一個值："); // 提示使用者輸入值
            string input = Console.ReadLine(); // 讀取使用者輸入的值
            bool isNumeric = NumberChecker.IsNumeric(input); // 呼叫IsNumeric方法，檢查字串是否為數字
            Console.WriteLine($"輸入的值是否為數字：{isNumeric}"); // 輸出結果，顯示是否為數字
            Console.ReadKey();
        }
    }
}*/
#endregion

#region 3.
/*namespace ch6_function
{
    public class EmailChecker // 定義一個名為EmailChecker的類別
    {
        public static bool IsValidEmail(string input) // 定義一個靜態方法，檢查輸入是否為有效的E-mail格式
        {
            if (string.IsNullOrEmpty(input)) // 檢查輸入是否為空或null
            {
                return false; // 如果是，返回false
            }

            // 使用正規表達式檢查輸入是否符合E-mail格式
            return Regex.IsMatch(input, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"); // 如果輸入符合E-mail格式，返回true，否則返回false
        }
    }

    // 測試函式
    public class Program // 定義一個名為Program的類別
    {
        public static void Main() // 主方法，程式執行的入口點
        {
            Console.WriteLine("請輸入一個E-mail地址："); // 提示使用者輸入E-mail地址
            string input = Console.ReadLine(); // 讀取使用者輸入的值
            bool isValidEmail = EmailChecker.IsValidEmail(input); // 呼叫IsValidEmail方法，檢查字串是否為有效的E-mail格式
            Console.WriteLine($"輸入的值是否為有效的E-mail地址：{isValidEmail}"); // 輸出結果，顯示是否為有效的E-mail格式
            Console.ReadKey(); // 等待使用者按任意鍵後結束程式，避免視窗自動關閉
        }
    }
}*/
#endregion

#region 4.
/*namespace ch6_function
{
    public class PhoneNumberChecker // 定義一個名為PhoneNumberChecker的類別
    {
        public static bool IsValidPhoneNumber(string input) // 定義一個靜態方法，檢查輸入是否為有效的手機格式
        {
            if (string.IsNullOrEmpty(input)) // 檢查輸入是否為空或null
            {
                return false; // 如果是，返回false
            }

            // 使用正規表達式檢查輸入是否符合手機格式
            return Regex.IsMatch(input, @"^\d{10}$"); // 如果輸入符合10位數字的手機格式，返回true，否則返回false
        }
    }

    // 測試函式
    public class Program // 定義一個名為Program的類別
    {
        public static void Main() // 主方法，程式執行的入口點
        {
            Console.WriteLine("請輸入一個手機號碼："); // 提示使用者輸入手機號碼
            string input = Console.ReadLine(); // 讀取使用者輸入的值
            bool isValidPhoneNumber = PhoneNumberChecker.IsValidPhoneNumber(input); // 呼叫IsValidPhoneNumber方法，檢查字串是否為有效的手機格式
            Console.WriteLine($"輸入的值是否為有效的手機號碼：{isValidPhoneNumber}"); // 輸出結果，顯示是否為有效的手機格式
            Console.ReadKey(); // 等待使用者按任意鍵後結束程式，避免視窗自動關閉
        }
    }
}*/
#endregion

#region 5.
/*namespace ch6_function
{
    public class IDChecker // 定義一個名為IDChecker的類別
    {
        public static bool IsValidTaiwanID(string input) // 定義一個靜態方法，檢查輸入是否為有效的台灣身分證字號格式
        {
            if (string.IsNullOrEmpty(input)) // 檢查輸入是否為空或null
            {
                return false; // 如果是，返回false
            }

            // 使用正規表達式檢查輸入是否符合台灣身分證字號格式
            return Regex.IsMatch(input, @"^[A-Z][12]\d{8}$"); // 如果輸入符合格式，返回true，否則返回false
        }
    }

    // 測試函式
    public class Program // 定義一個名為Program的類別
    {
        public static void Main() // 主方法，程式執行的入口點
        {
            Console.WriteLine("請輸入一個台灣身分證字號："); // 提示使用者輸入台灣身分證字號
            string input = Console.ReadLine(); // 讀取使用者輸入的值
            bool isValidID = IDChecker.IsValidTaiwanID(input); // 呼叫IsValidTaiwanID方法，檢查字串是否為有效的台灣身分證字號格式
            Console.WriteLine($"輸入的值是否為有效的台灣身分證字號：{isValidID}"); // 輸出結果，顯示是否為有效的台灣身分證字號格式
            Console.ReadKey(); // 等待使用者按任意鍵後結束程式，避免視窗自動關閉
        }
    }
}*/
#endregion

#region 6.
/*namespace ch6_function
{
    public class TextTrimmer // 定義一個名為TextTrimmer的類別
    {
        public static string TrimText(string input, int maxLength) // 定義一個靜態方法，檢查並截斷輸入的文字
        {
            if (string.IsNullOrEmpty(input)) // 檢查輸入是否為空或null
            {
                return string.Empty; // 如果是，返回空字串
            }

            if (input.Length > maxLength) // 檢查輸入的文字長度是否超過指定的最大長度
            {
                return input.Substring(0, maxLength) + "..."; // 如果超過，截斷並加上省略號
            }

            return input; // 如果沒有超過，返回原始文字
        }
    }

    // 測試函式
    public class Program // 定義一個名為Program的類別
    {
        public static void Main() // 主方法，程式執行的入口點
        {
            Console.WriteLine("請輸入一段文字："); // 提示使用者輸入文字
            string input = Console.ReadLine(); // 讀取使用者輸入的值
            Console.WriteLine("請輸入最大長度："); // 提示使用者輸入最大長度
            int maxLength = int.Parse(Console.ReadLine()); // 讀取並解析使用者輸入的最大長度
            string trimmedText = TextTrimmer.TrimText(input, maxLength); // 呼叫TrimText方法，檢查並截斷文字
            Console.WriteLine($"截斷後的文字：{trimmedText}"); // 輸出結果，顯示截斷後的文字
            Console.ReadKey(); // 等待使用者按任意鍵後結束程式，避免視窗自動關閉
        }
    }
}*/
#endregion

#region 7.
/*namespace ch6_function
{
    public class DateConverter // 定義一個名為DateConverter的類別
    {
        public static string ConvertToTaiwanDate(DateTime date) // 定義一個靜態方法，將日期轉換成民國年.月.日格式
        {
            int taiwanYear = date.Year - 1911; // 計算民國年，西元年減去1911
            return $"{taiwanYear}年{date.Month}月{date.Day}日"; // 返回格式化的民國日期字串
        }
    }

    // 測試函式
    public class Program // 定義一個名為Program的類別
    {
        public static void Main() // 主方法，程式執行的入口點
        {
            Console.WriteLine("請輸入一個日期（格式：yyyy-MM-dd）："); // 提示使用者輸入日期
            string input = Console.ReadLine(); // 讀取使用者輸入的值
            DateTime date; // 定義一個DateTime變數
            if (DateTime.TryParse(input, out date)) // 嘗試解析使用者輸入的日期
            {
                string taiwanDate = DateConverter.ConvertToTaiwanDate(date); // 呼叫ConvertToTaiwanDate方法，轉換日期
                Console.WriteLine($"轉換後的民國日期：{taiwanDate}"); // 輸出結果，顯示轉換後的民國日期
            }
            else
            {
                Console.WriteLine("輸入的日期格式不正確。"); // 如果解析失敗，提示輸入格式不正確
            }
            Console.ReadKey(); // 等待使用者按任意鍵後結束程式，避免視窗自動關閉
        }
    }
}*/
#endregion

#region 8.
/*namespace ch6_function
{
    public class DateConverter // 定義一個名為DateConverter的類別
    {
        public static string ConvertToTaiwanDateWithDayOfWeek(DateTime date) // 定義一個靜態方法，將日期轉換成民國年.月.日 星期格式
        {
            int taiwanYear = date.Year - 1911; // 計算民國年，西元年減去1911
            string dayOfWeek; // 定義一個字串變數，用於存儲星期的中文表示

            switch (date.DayOfWeek) // 使用傳統的switch語句獲取星期的中文表示
            {
                case DayOfWeek.Sunday:
                    dayOfWeek = "星期日";
                    break;
                case DayOfWeek.Monday:
                    dayOfWeek = "星期一";
                    break;
                case DayOfWeek.Tuesday:
                    dayOfWeek = "星期二";
                    break;
                case DayOfWeek.Wednesday:
                    dayOfWeek = "星期三";
                    break;
                case DayOfWeek.Thursday:
                    dayOfWeek = "星期四";
                    break;
                case DayOfWeek.Friday:
                    dayOfWeek = "星期五";
                    break;
                case DayOfWeek.Saturday:
                    dayOfWeek = "星期六";
                    break;
                default:
                    dayOfWeek = string.Empty; // 預設返回空字串
                    break;
            }

            return $"{taiwanYear}年{date.Month}月{date.Day}日 {dayOfWeek}"; // 返回格式化的民國日期字串，包含星期
        }
    }

    // 測試函式
    public class Program // 定義一個名為Program的類別
    {
        public static void Main() // 主方法，程式執行的入口點
        {
            Console.WriteLine("請輸入一個日期（格式：yyyy-MM-dd）："); // 提示使用者輸入日期
            string input = Console.ReadLine(); // 讀取使用者輸入的值
            if (DateTime.TryParse(input, out DateTime date)) // 嘗試解析使用者輸入的日期，並內置變數宣告
            {
                string taiwanDate = DateConverter.ConvertToTaiwanDateWithDayOfWeek(date); // 呼叫ConvertToTaiwanDateWithDayOfWeek方法，轉換日期
                Console.WriteLine($"轉換後的民國日期：{taiwanDate}"); // 輸出結果，顯示轉換後的民國日期
            }
            else
            {
                Console.WriteLine("輸入的日期格式不正確。"); // 如果解析失敗，提示輸入格式不正確
            }
            Console.ReadKey(); // 等待使用者按任意鍵後結束程式，避免視窗自動關閉
        }
    }
}*/
#endregion

#region 9.
/*namespace ch6_function
{
    public class LeapYearChecker // 定義一個名為LeapYearChecker的類別
    {
        public static bool IsLeapYear(int year) // 定義一個靜態方法，檢查輸入的年份是否為閏年
        {
            // 閏年的條件：能被4整除且不能被100整除，或者能被400整除
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0); // 返回是否為閏年
        }
    }

    // 測試函式
    public class Program // 定義一個名為Program的類別
    {
        public static void Main() // 主方法，程式執行的入口點
        {
            Console.WriteLine("請輸入一個年份："); // 提示使用者輸入年份
            string input = Console.ReadLine(); // 讀取使用者輸入的值
            int year; // 定義一個整數變數，用於存儲年份
            if (int.TryParse(input, out year)) // 嘗試解析使用者輸入的年份
            {
                bool isLeapYear = LeapYearChecker.IsLeapYear(year); // 呼叫IsLeapYear方法，檢查年份是否為閏年
                Console.WriteLine($"輸入的年份是否為閏年：{isLeapYear}"); // 輸出結果，顯示是否為閏年
            }
            else
            {
                Console.WriteLine("輸入的年份格式不正確。"); // 如果解析失敗，提示輸入格式不正確
            }
            Console.ReadKey(); // 等待使用者按任意鍵後結束程式，避免視窗自動關閉
        }
    }
}*/
#endregion

#region 10.
namespace ch6_function
{
    public class FortuneCalculator // 定義一個名為FortuneCalculator的類別
    {
        public static double CalculateFortune(string phoneNumber) // 定義一個靜態方法，根據手機號碼計算運勢
        {
            if (phoneNumber.Length < 4) // 檢查手機號碼是否少於4位數
            {
                throw new ArgumentException("手機號碼必須至少有4位數。"); // 如果是，拋出異常
            }

            string lastFourDigits = phoneNumber.Substring(phoneNumber.Length - 4); // 取得手機號碼的最後四位數
            int lastFourDigitsNumber = int.Parse(lastFourDigits); // 將最後四位數轉換為整數

            double result = (lastFourDigitsNumber % 80) / 80.0; // 用最後四位數除以80，並取餘數，再除以80
            result = (result - Math.Floor(result)) * 80; // 減去整數部分（只留小數），再乘以80

            return result; // 返回計算結果，代表吉凶的數字
        }
    }

    // 測試函式
    public class Program // 定義一個名為Program的類別
    {
        public static void Main() // 主方法，程式執行的入口點
        {
            Console.WriteLine("請輸入你的手機號碼："); // 提示使用者輸入手機號碼
            string phoneNumber = Console.ReadLine(); // 讀取使用者輸入的手機號碼

            try // 嘗試執行以下程式碼，捕捉可能的異常
            {
                double fortuneNumber = FortuneCalculator.CalculateFortune(phoneNumber); // 呼叫CalculateFortune方法，計算運勢
                Console.WriteLine($"今天的運勢數字是：{fortuneNumber} , 請到以下網址查找詳細內容：https://kknews.cc/astrology/p2x8ekp.html"); // 輸出結果，顯示運勢數字
            }
            catch (Exception ex) // 捕捉異常
            {
                Console.WriteLine($"錯誤：{ex.Message}"); // 輸出錯誤訊息
            }

            Console.ReadKey(); // 等待使用者按任意鍵後結束程式，避免視窗自動關閉
        }
    }
}
#endregion