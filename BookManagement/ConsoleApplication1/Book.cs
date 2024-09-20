using System.Dynamic;

namespace ConsoleApplication1
{
    public class Book
    {
        public int ID{get;set;}
        public string Name{get;set;}
        public string Author{get;set;}
        private int Price{get;set;}
        private int Quantity{get;set;}
        public int year{get;set;}
        public override string ToString()
        {
       return "Name : " + Name + ", Author : " + Author + ", Price : " + Price;
        }
    }
    
    
    
}