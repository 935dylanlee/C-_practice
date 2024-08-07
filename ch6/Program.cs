using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            //Console.WriteLine("請輸入您的姓名："); // 使用 Console.WriteLine 方法在控制台上輸出提示訊息，告訴使用者輸入姓名。

            //string name = Console.ReadLine(); // 使用 Console.ReadLine 方法從控制台讀取使用者輸入的姓名，並將其存儲在變數 name 中。

            //string greeting = "Hi~" + name; // 使用字符串連接運算符 + 將 "Hi~" 和使用者輸入的姓名連接起來，並將結果存儲在變數 greeting 中。

            //Console.WriteLine(greeting); // 使用 Console.WriteLine 方法在控制台上輸出問候語，這裡會顯示 Hi~ 加上使用者的姓名
            //Console.ReadKey();

            //2.
            //Console.WriteLine("請輸入一個字："); // 使用 Console.WriteLine 方法在控制台上輸出提示訊息，告訴使用者輸入一個字。

            //string input = Console.ReadLine(); // 使用 Console.ReadLine 方法從控制台讀取使用者輸入的字，並將其存儲在變數 input 中。

            //string phrase = "人人為我，我為人人、饒人不癡漢，癡漢不饒人"; // 定義一個字串變數 phrase，包含我們要檢查的句子。

            //bool contains = phrase.Contains(input); // 使用字符串方法 Contains 檢查字串 phrase 是否包含使用者輸入的字，並將結果存儲在變數 contains 中。

            //if (contains) // 使用 if 語句檢查變數 contains 是否為 true。
            //{
            //    Console.WriteLine("字串中包含您輸入的字。"); // 如果 contains 為 true，則在控制台上輸出確認訊息。
            //}
            //else
            //{
            //    Console.WriteLine("字串中不包含您輸入的字。"); // 如果 contains 為 false，則在控制台上輸出否定訊息。
            //}
            //Console.ReadKey();

            //3.
            //Console.WriteLine("請輸入一段字："); // 使用 Console.WriteLine 方法在控制台上輸出提示訊息，告訴使用者輸入一段字。

            //string input = Console.ReadLine(); // 使用 Console.ReadLine 方法從控制台讀取使用者輸入的字串，並將其存儲在變數 input 中。

            //string result = string.Join("-", input.ToCharArray()); // 使用字符串方法 Join 將字串轉換為字符陣列，並在每個字符之間插入 "-"，然後將結果存儲在變數 result 中。

            //Console.WriteLine(result); // 使用 Console.WriteLine 方法在控制台上輸出最終結果，即每個字符之間多一個 "-" 的字串。
            //Console.ReadKey();

            //4.
            //Console.WriteLine("請輸入一個檔名："); // 使用 Console.WriteLine 方法在控制台上輸出提示訊息，告訴使用者輸入一個檔名。

            //string fileName = Console.ReadLine(); // 使用 Console.ReadLine 方法從控制台讀取使用者輸入的檔名，並將其存儲在變數 fileName 中。

            //string extension = System.IO.Path.GetExtension(fileName); // 使用 System.IO.Path 類的 GetExtension 方法取得檔名的副檔名，並將結果存儲在變數 extension 中。

            //if (!string.IsNullOrEmpty(extension) && extension.StartsWith(".")) // 檢查副檔名是否不為空且以 "." 開頭。
            //{
            //    extension = extension.Substring(1); // 去掉副檔名前面的 "."。
            //}

            //Console.WriteLine("副檔名是：" + extension); // 使用 Console.WriteLine 方法在控制台上輸出副檔名。
            //Console.ReadKey ();

            //5.
            //Console.WriteLine("請輸入一個大於五個字的單字："); // 使用 Console.WriteLine 方法在控制台上輸出提示訊息，告訴使用者輸入一個大於五個字的單字。

            //string input = Console.ReadLine(); // 使用 Console.ReadLine 方法從控制台讀取使用者輸入的單字，並將其存儲在變數 input 中。

            //if (input.Length <= 5) // 使用字符串屬性 Length 檢查輸入的單字長度是否小於或等於五個字。
            //{
            //    Console.WriteLine("長度不夠"); // 如果單字長度小於或等於五個字，則在控制台上輸出 "長度不夠"。
            //}
            //else // 如果單字長度大於五個字，則執行以下代碼。
            //{
            //    string result = input.Substring(0, 3); // 使用字符串方法 Substring 取得單字的前三個字，並將結果存儲在變數 result 中。
            //    Console.WriteLine("前三個字是：" + result); // 使用 Console.WriteLine 方法在控制台上輸出前三個字。
            //}
            //Console.ReadKey();

            //6.
            //Console.WriteLine("請輸入一段字："); // 使用 Console.WriteLine 方法在控制台上輸出提示訊息，告訴使用者輸入一段字。

            //string input = Console.ReadLine(); // 使用 Console.ReadLine 方法從控制台讀取使用者輸入的字串，並將其存儲在變數 input 中。

            //string result = input.Replace("我", "小明"); // 使用字符串方法 Replace 將字串中的 "我" 替換為 "小明"，並將結果存儲在變數 result 中。

            //Console.WriteLine(result); // 使用 Console.WriteLine 方法在控制台上輸出最終結果，即替換後的字串。
            //Console.ReadKey();

            //7.
            //Console.WriteLine("請輸入一串字："); // 使用 Console.WriteLine 方法在控制台上輸出提示訊息，告訴使用者輸入一串字。

            //string input = Console.ReadLine(); // 使用 Console.ReadLine 方法從控制台讀取使用者輸入的字串，並將其存儲在變數 input 中。

            //int length = input.Length; // 使用字符串屬性 Length 取得字串的長度，並將結果存儲在變數 length 中。

            //Console.WriteLine("您輸入了 " + length + " 個字。"); // 使用 Console.WriteLine 方法在控制台上輸出字串的長度。
            //Console.ReadKey();

            //補充1.
            //HashSet<string> inputSet = new HashSet<string>(); // 使用 HashSet 類來存儲已輸入過的字串，避免重複。

            //Console.WriteLine("請輸入10組字："); // 使用 Console.WriteLine 方法在控制台上輸出提示訊息，告訴使用者輸入10組字。

            //for (int i = 0; i < 10; i++) // 使用 for 迴圈來連續輸入 10 組字。
            //{
            //    Console.WriteLine($"請輸入第 {i + 1} 組字："); // 提示目前是第幾組輸入。
            //    string input = Console.ReadLine(); // 使用 Console.ReadLine 方法從控制台讀取使用者輸入的字串，並將其存儲在變數 input 中。
            //    inputSet.Add(input); // 將新的字串加入到 HashSet 中。
            //}

            //Console.WriteLine("請輸入一組字進行比對："); // 使用 Console.WriteLine 方法在控制台上輸出提示訊息，告訴使用者輸入一組字進行比對。
            //string compareInput = Console.ReadLine(); // 使用 Console.ReadLine 方法從控制台讀取使用者輸入的字串，並將其存儲在變數 compareInput 中。

            //if (inputSet.Contains(compareInput)) // 使用 HashSet 的 Contains 方法檢查字串是否已經輸入過。
            //{
            //    Console.WriteLine("輸入過"); // 如果字串已經輸入過，則在控制台上輸出 "輸入過"。
            //}
            //else // 如果字串沒有輸入過，則執行以下代碼。
            //{
            //    Console.WriteLine("沒出現過"); // 在控制台上輸出 "沒出現過"。
            //}
            //Console.ReadKey();

            //補充2.
            //Console.WriteLine("請輸入一段字："); // 使用 Console.WriteLine 方法在控制台上輸出提示訊息，告訴使用者輸入一段字。

            //string input = Console.ReadLine(); // 使用 Console.ReadLine 方法從控制台讀取使用者輸入的字串，並將其存儲在變數 input 中。

            //for (int i = 0; i < input.Length; i++) // 使用 for 迴圈遍歷字串的每一個字符。
            //{
            //    char[] chars = input.ToCharArray(); // 使用 ToCharArray 方法將字串轉換為字符陣列。

            //    chars[i] = char.ToUpper(chars[i]); // 將當前字符轉換為大寫。

            //    for (int j = 0; j < chars.Length; j++) // 使用內部 for 迴圈來處理其他字符。
            //    {
            //        if (j != i) // 如果不是當前字符，則轉換為小寫。
            //        {
            //            chars[j] = char.ToLower(chars[j]);
            //        }
            //    }

            //    string result = new string(chars); // 將字符陣列轉換回字串。
            //    Console.WriteLine($"輸出{result}"); // 使用 Console.WriteLine 方法在控制台上輸出結果。
            //}
            //Console.ReadKey();

            //補充3.
            //Console.WriteLine("請輸入時間（格式：HH:mm）："); // 使用 Console.WriteLine 方法在控制台上輸出提示訊息，告訴使用者輸入時間。

            //string input = Console.ReadLine(); // 使用 Console.ReadLine 方法從控制台讀取使用者輸入的字串，並將其存儲在變數 input 中。

            //string[] timeParts = input.Split(':'); // 使用 Split 方法將輸入的時間字串按冒號分割成小時和分鐘兩部分，並存儲在陣列 timeParts 中。

            //string hour = timeParts[0]; // 取得時間的小時部分，並存儲在變數 hour 中。
            //string minute = timeParts[1]; // 取得時間的分鐘部分，並存儲在變數 minute 中。

            //string result = $"{hour}點{minute}分"; // 使用字串插值將小時和分鐘組合成所需的格式，並存儲在變數 result 中。

            //Console.WriteLine(result); // 使用 Console.WriteLine 方法在控制台上輸出最終結果。
            //Console.ReadKey();

            //補充4.
            //Console.WriteLine("請輸入名字，用逗號分隔（例如：Justin,Amy,David）："); // 使用 Console.WriteLine 方法在控制台上輸出提示訊息，告訴使用者輸入名字。

            //string input = Console.ReadLine(); // 使用 Console.ReadLine 方法從控制台讀取使用者輸入的字串，並將其存儲在變數 input 中。

            //string[] names = input.Split(','); // 使用 Split 方法將輸入的字串按逗號分割成多個名字，並存儲在陣列 names 中。

            //Console.WriteLine("<ul>"); // 使用 Console.WriteLine 方法在控制台上輸出 HTML 的 <ul> 標籤，表示無序列表的開始。

            //foreach (string name in names) // 使用 foreach 迴圈遍歷每個名字。
            //{
            //    Console.WriteLine($"\t<li>{name}</li>"); // 使用 Console.WriteLine 方法在控制台上輸出每個名字的 <li> 標籤，表示列表項。
            //}

            //Console.WriteLine("</ul>"); // 使用 Console.WriteLine 方法在控制台上輸出 HTML 的 </ul> 標籤，表示無序列表的結束。
            //Console.ReadKey();

            //補充5.
            //Console.WriteLine("請輸入5處數字，用空白隔開："); // 使用 Console.WriteLine 方法在控制台上輸出提示訊息，告訴使用者輸入5處數字。

            //string input = Console.ReadLine(); // 使用 Console.ReadLine 方法從控制台讀取使用者輸入的字串，並將其存儲在變數 input 中。

            //string[] numbers = input.Split(' '); // 使用 Split 方法將輸入的字串按空白分割成多個數字，並存儲在陣列 numbers 中。

            //int sum = 0; // 定義一個整數變數 sum，並初始化為0，用來存儲總和。

            //foreach (string number in numbers) // 使用 foreach 迴圈遍歷每個數字。
            //{
            //    sum += int.Parse(number); // 使用 int.Parse 方法將字串轉換為整數，並累加到 sum 中。
            //}

            //Console.WriteLine($"總和是 {sum}"); // 使用 Console.WriteLine 方法在控制台上輸出總和結果。
            //Console.ReadKey();

            //補充6.
            Console.WriteLine("請輸入一串文字："); // 使用 Console.WriteLine 方法在控制台上輸出提示訊息，告訴使用者輸入一串文字。

            string input = Console.ReadLine(); // 使用 Console.ReadLine 方法從控制台讀取使用者輸入的字串，並將其存儲在變數 input 中。

            char[] charArray = input.ToCharArray(); // 使用 ToCharArray 方法將字串轉換為字符陣列。
            Array.Reverse(charArray); // 使用 Array.Reverse 方法將字符陣列倒序排列。

            string reversedString = new string(charArray); // 將倒序排列的字符陣列轉換回字串。

            Console.WriteLine(reversedString); // 使用 Console.WriteLine 方法在控制台上輸出倒序後的字串。
            Console.ReadKey();
        }
    }
}
