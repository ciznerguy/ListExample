using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    internal class Program
    {
        public static void ListExample()
        {
            List<int> list = new List<int>();   
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            foreach (int value in list)
            {
                Console.WriteLine(value);
            }
            int index = list.IndexOf(4);
            Console.WriteLine($"index of 4 is {index}");
        }

        public static void ListExample2()
        {
            Console.OutputEncoding = Encoding.UTF8; // כדי שיציג גם ערכים בעברית

            // יצירת רשימה עם ערכים מסוג מחרוזת
            List<String> fruitsNameList = new List<String>() { "תפוח", "אבוקדו" };

            // הכנסת ערכים לרשימה על פי מיקום
            fruitsNameList.Insert(0, "בננה");
            fruitsNameList.Insert(2, "ענבים");

            List<String> fruitsName = new List<String>() { "מנגו", "תפוז" };

            // שילוב של שתי רשימות במיקום מסוים
            fruitsNameList.InsertRange(2, fruitsName);
            Console.WriteLine("****** הדפסת ערכי הרשימה ******");
            foreach (string item in fruitsNameList)
            {
                Console.WriteLine($" {item} ");
            }
       
        }

       
        static void Main(string[] args)
        {

            ListExample2();
           
        }
    }
}
