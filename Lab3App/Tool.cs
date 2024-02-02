using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Tool : Collectable
    {
        protected Tool(string description)
        {
            description = description;
        }
        public abstract void DoAction();
        public override void AddMe(List<Collectable> collection)
        {
            collection.Add(this);
            Console.WriteLine($"{description} Collected, Congrats!!!!");
            DoAction();
        }
    }
}
