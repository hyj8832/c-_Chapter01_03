using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01_03
{
    class Program
    {
        class CMyInt
        {
            public int theValue;
            public override string ToString()
            {
                //Console.WriteLine("-");
                return theValue.ToString();
            }
        }

        static void Main(string[] args)
        {
            int a = 12345;
            int b = a;
            Console.WriteLine("Before");
            Console.WriteLine("a:{0}", a);
            Console.WriteLine("b:{0}", b);

            a = 98765;
            Console.WriteLine("After");
            Console.WriteLine("a:{0}", a);
            Console.WriteLine("b:{0}", b);

            object c = 12345;
            object d = c;
            Console.WriteLine("Before");
            Console.WriteLine("c:{0}", c);
            Console.WriteLine("d:{0}", d);

            c = 98765;
            Console.WriteLine("After");
            Console.WriteLine("c:{0}", c);
            Console.WriteLine("d:{0}", d);//object라고 주소값 가진다고 오해하지 말자.

            CMyInt e = new CMyInt();
            e.theValue = 12345;
            CMyInt f = e;
            Console.WriteLine("Before");
            Console.WriteLine("e:{0}", e);
            Console.WriteLine("f:{0}", f);

            e.theValue = 98765;
            Console.WriteLine("After");
            Console.WriteLine("e:{0}", e);
            Console.WriteLine("f:{0}", f); //객체이기 때문에 주소값을 가진다.


            //Console.Write("Input Name: ");
            //string tmpName = Console.ReadLine();
            //Console.WriteLine("Your Name: {0}", tmpName);

            /*Console.Write("Input Number : ");
            string tempNumber = Console.ReadLine();
            Console.WriteLine("100+input= {0}", 100+Int32.Parse(tempNumber));*/

            //int.parse()   , Int32.parse() ,  Convert.ToInt32() 다 같은ㄱ ㅓ

            //Console.Write("\nInput Char: ");
            //ConsoleKeyInfo tmpKey = Console.ReadKey();

            //int i;
            //for (i = 0; i < tmpName.Length; i++)
            //{
            //   if(tmpName[i].Equals(tmpKey.KeyChar) == true) //홍, 이, 주 이렇게 가져오는거 [i]
            //    {
            //        break;
            //    }
            //}
            //if (i == tmpName.Length)
            //{
            //    Console.WriteLine("\nChar : {0} Fail", tmpKey.KeyChar);

            //}
            //else
            //{
            //    Console.WriteLine("\nChar : {0} Success", tmpKey.KeyChar);

            //}


            string strSW = "apple";
            switch (strSW)
            {
                case "apple":
                    Console.WriteLine("apple,apple");
                    break;
                case "banana":
                    Console.WriteLine("banana,banana");
                    break;
                default:
                    Console.WriteLine("Fruits");
                    break;
            }

            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i <= 4; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            foreach (int iter in arr)
            {
                Console.Write("{0}", iter);
            }
            Console.WriteLine();

            int[] tmpPoints = new int[(int)EFruit.EF_Count];
            Console.Write((int)EFruit.EF_Count);
            for (int i = 0; i < (int)EFruit.EF_Count; i++)
            {
                tmpPoints[i] = i + 1;
            }
            for (int i = 0; i < (int)EFruit.EF_Count; i++)
            {
                Console.Write(tmpPoints[i]);
                Console.Write(":");
                Console.WriteLine(i+",");
                Console.WriteLine((EFruit)i);
            }
           
        }
            enum EFruit{
            EF_Apple,
            EF_Banana,
            EF_Lemon,
            EF_Count
              }

    }
}
