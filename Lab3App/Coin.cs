using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure
    {
        public int Value { get; set; }
        public Coin(string description, int score, int value) : base(description, score)
        {
            Value = value;
        }
        public override void UpdateTotalValue()
        {
            Board.UpdateTotalValue(Value);
        }
        public override void Display()
        {
            Console.WriteLine($"Coin {description} is displayed");
        }

    }
}
