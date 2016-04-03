using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AbstracTest
{
    //public abstract class Father
    //{
    //    public string name = "asd";
    //    public string GetName()
    //    {
    //        return this.name;
    //    }
    //}
    //public class Son : Father
    //{
    //    string name = "son";
        
    // }
    public interface IFlyAble
    {
        string name { get; set; }
    }
    public class Bird : IFlyAble
    {
        public string qweqwe;

        public string name
        {
            get
            {
                return "asdasasdasdds";
            }

            set { qweqwe = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
              Regex
            
            //Console.WriteLine(Regex.IsMatch(,));
            Console.Read();

        }
    }
}
