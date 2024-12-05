using System;

namespace structs
{
   
        public struct customer
        {
            private int _id;
            private string _name;
            public string name
            {
                get{return _name;}
                set{_name=value;}
            } 
            public int id
            {
                get { return this._id; }
                set{ this._id = value; }
            }
            public customer(int id,string name)
            {
                this._id = id;
                this._name = name;
            }
            public void printDetails()
            {
                Console.WriteLine("id = {0} && name = {1}", this._id, this._name);
            }
        }
    

        
    internal class Program
    {
        static void Main(string[] args)
        {
            customer c1 = new customer(101, "marks");
            c1.printDetails();

            customer c2 = new customer();
            c2.id = 102;
            c2.name = "john";
            c2.printDetails();

            customer c3 = new customer
            {
                id = 103,
                name = "Rob"
            };
            c3.printDetails();
        }
    }
}
