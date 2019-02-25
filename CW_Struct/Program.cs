using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Struct
{
    enum Operator : int
    {
        Add = 1,
        Substract,
        Divide = 56,
        Multyplay
    }
    public enum Gender
    {
        male, famale, other
    }

    public class User
    {
        public Address address { get; set; }
    }
    public class Address
    {
        public string street { get; set; }
    }

    class Program
    {
        public static Nullable<int> MyProperty { get; set; } = null; //чтобы работать с базой данных,использовать null в С# int?
        //public int? MyProperty2 { get; set; } = null;
        static void EvalNum(System.Enum e)
        {
            int x = 0;
            if(MyProperty!=null)
            {
                x = (int)MyProperty;
            }
            else
            {
                x = 0;
            }
            x = MyProperty ?? 0;
            Console.WriteLine(e.GetType().Name);
            Console.WriteLine(Enum.GetUnderlyingType(e.GetType()));

            Array enumData = Enum.GetValues(e.GetType());
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Values:{0:D}", enumData.GetValue(i));

            }
          
        }
        static void Main(string[] args)
        {

            Operator oper = Operator.Add;
            EvalNum(oper);

            string gender = Console.ReadLine();
            if (Enum.IsDefined(typeof(Gender), gender))
            {
                Gender d = (Gender)Enum.Parse(typeof(Gender), gender);

            }
            else
            {
                Console.WriteLine("Введите корректный пол");
            }
        }
    }
}
