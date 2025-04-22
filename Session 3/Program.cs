using System.Collections.Concurrent;
using System.Net.Security;
using System.Text;
using System.Threading.Channels;

namespace Session_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF

            //Console.WriteLine("Enter number : ");
            //int.TryParse(Console.ReadLine(), out int num);

            //if (num == 0)
            //{
            //    Console.WriteLine("Zero");
            //}
            //else if (num == 1)
            //{
            //    Console.WriteLine("One");
            //}
            //else
            //{
            //    Console.WriteLine("nothing");
            //}
            #endregion

            #region Switch1

            //Console.WriteLine("Enter number : ");
            //int.TryParse(Console.ReadLine(), out int num);

            //switch (num)
            //{
            //    case 0:
            //        Console.WriteLine("zero");
            //        break;
            //    case 1:
            //        Console.WriteLine("one");
            //        break;

            //    default:
            //        Console.WriteLine("nothing");
            //        break;
            #endregion

            #region Switch2
            //Console.WriteLine("Enter number : ");
            //int.TryParse(Console.ReadLine(), out int num);

            //switch (num)
            //{
            //    case > 20:
            //    Console.WriteLine("Grater");
            //    break;

            //    case < 20:
            //    Console.WriteLine("less");
            //    break;

            //    default:
            //    Console.WriteLine("nothing");
            //    break;
            //} 
            #endregion

            #region Switch3
            //string? name = Console.ReadLine();
            //switch (name)
            //{
            //    case "essam":
            //        Console.WriteLine("hi essam");
            //        break;

            //    case "alaa":
            //        Console.WriteLine("hi essam alaa");
            //        break;

            //    case "omar":
            //        Console.WriteLine("hi essam alaa omar");
            //        break;

            //    default:
            //        Console.WriteLine("hello nobody");
            //        break;
            //} 
            #endregion

            #region Switch4 : GoTo
            //Console.WriteLine("Enter number : ");
            //int.TryParse(Console.ReadLine(), out int salary);

            //switch (salary)
            //{
            //    case 3000:
            //        Console.WriteLine("option03");
            //        //Console.WriteLine("option02");
            //        //Console.WriteLine("option01");
            //        goto case 2000;

            //    case 2000:
            //        Console.WriteLine("option02");
            //        //Console.WriteLine("option01");
            //        goto case 1000;

            //    case 1000:
            //        Console.WriteLine("option01");
            //        break;

            //    default:
            //        Console.WriteLine("nope");
            //        break;

            //} 
            #endregion

            #region for & for each
            //int[] num = { 1, 2, 3, 4, 5, };

            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);

            //}

            //Console.WriteLine("******");


            //foreach(int n in num)
            //{
            //    Console.WriteLine(n);
            //} 
            #endregion

            #region while & do..while
            //int num;
            //do
            //{
            //    Console.WriteLine("Enter Number : ");
            //    int.TryParse(Console.ReadLine(), out num);

            //}
            //while (num % 2 == 1);


            //int n = 1;
            //while (n < 10)
            //{
            //    Console.WriteLine("hi");
            //    n++;
            //} 
            #endregion

            #region String 
            //string name01;
            //name01 = "Essam";
            ////Console.WriteLine(name01);
            ////Console.WriteLine(name01.GetHashCode()); 
            ////name01 = "Alaa";
            ////Console.WriteLine(name01);
            ////Console.WriteLine(name01.GetHashCode());

            //string name02;
            //name02 = "Brono";
            ////Console.WriteLine(name02);
            ////Console.WriteLine(name02.GetHashCode());

            //name02 = name01;
            //Console.WriteLine(name01);
            //Console.WriteLine(name02);
            //Console.WriteLine(name01.GetHashCode());
            //Console.WriteLine(name02.GetHashCode()); 
            #endregion

            #region StringBuilder 
            //StringBuilder s = new StringBuilder("Hi");
            //s.Append("Hi");
            //s.Append(" Essam");
            //s.AppendLine(" Brunoo F8");
            //s.AppendFormat("{ 0} + {1} = {2} ,5,6,8"); ????? مش فاهم؟
            //s.AppendJoin(";", "Essam", "alaa");
            //s.Insert(2,"essam");
            //s.Remove(0, 1);
            //s.Replace("H", "%");
            //Console.WriteLine(s); 
            #endregion

        }
    }
}