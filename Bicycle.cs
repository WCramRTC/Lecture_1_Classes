using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1_Classes
{
    public class Bicycle
    {
        enum TypesOfChains { Chain1, Chain2, Chain3 }
        // Fields
        string _breaks;
        TypesOfChains  _chain;
        string _typeOfWheels;
        int _numberOfGears;
        string _frame;
        string _pedals;
        string _handle;
        int _numberOfSeats;
        string _uniqueSerial;

        // quICK ACTION
        // click on light bulb
        // Right click and selected
        // alt + enter
        // ctrl + .



        // Constructor
        public Bicycle(int numberOfSeats)
        {
            Random rand = new Random();
            int unique = rand.Next(10000000, 100000000);
            _uniqueSerial = unique.ToString();
            NumberOfSeats = numberOfSeats;
        }






        // Properties
        public string UniqueSerial
        {
            //get
            //{
            //    return _uniqueSerial;
            //}
            get => _uniqueSerial;
        }
     
        public int NumberOfSeats
        {
            get => _numberOfSeats;
            set
            {
                if(value >= 0)
                {
                    _numberOfSeats = value;
                }
                else
                {
                    Console.WriteLine("Please enter a postive value");
                }
            }
        }

        public string Breaks { get => _breaks; set => _breaks = value; }
        private TypesOfChains Chain { get => _chain; set => _chain = value; }
        public string TypeOfWheels { get => _typeOfWheels; set => _typeOfWheels = value; }
        public int NumberOfGears { get => _numberOfGears; set => _numberOfGears = value; }
        public string Frame { get => _frame; set => _frame = value; }
        public string Pedals { get => _pedals; set => _pedals = value; }
        public string Handle { get => _handle; set => _handle = value; }
        public int NumberOfSeats1 { get => _numberOfSeats; set => _numberOfSeats = value; }
        public string UniqueSerial1 { get => _uniqueSerial; set => _uniqueSerial = value; }


        // Methods


        public override string ToString()
        {
            return $"Unique Serial: {UniqueSerial}";
        }



    }
}
