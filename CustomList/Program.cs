using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> vs = new List<int>();
            CustomList<int> customList = new CustomList<int> {3, 1, 5, 2, 4 };

            CustomList<int> customList1 = new CustomList<int> { 6, 7, 8, 9, 10 };
            CustomList<string> customListStrings = new CustomList<string> { "Beckie ", "Casimira  ", "Myesha  ", "Monika  ", "Una  ", "Cesar  ", "Renae  ", "Aleisha  ", "Randy  ", "Jordon  ", "Geraldo  ", "Normand  ", "Marilu  ", "Madeline  ", "Francesco  ", "Hulda  ", "Carolyn  ", "Marline  ", "Anderson  ", "Marquitta  ", "Lupita  ", "Louella  ", "Lottie  ", "Alfonzo  ", "Yanira  ", "Rona  ", "Newton  ", "Latina  ", "Vicente  ", "Migdalia  ", "Winfred  ", "Somer  ", "Raphael  ", "Shakira  ", "Ghislaine  ", "Fiona  ", "Deanna  ", "Eldora  ", "Cinda  ", "Desmond  ", "Mistie  ", "Lashaun  ", "Dusty  ", "Tanja  ", "Christinia  ", "Rhea  ", "Marg  ", "Ashanti  ", "Filiberto  ", "Harley  " };
            Console.WriteLine(customList.Zip(customList1).ToString());
            Console.WriteLine(customList.Sort("descending"));
            Console.WriteLine(customListStrings.Sort("ascending"));
            customList.RemoveRange(4, 1);
            Console.WriteLine(customList);
            Console.ReadKey();
        }
    }
}
