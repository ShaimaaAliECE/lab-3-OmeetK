using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Diamond : Treasure

    {
        public int Value { get; set; }
        public Diamond(string description, int score) : base(description, score)
        {
        }
        public override void Display()
        {
            Console.WriteLine($"Diamond{description} is displayed");
        }
        public override void UpdateTotalValue()
        {
            Board.UpdateTotalValue(Value);
        }
    }
}
