using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Collectable : Displayable
    {
        public string description { get; set; }

        public CollectionBoard Board { get; set; }

        public abstract void Display();

        public abstract void AddMe(List<Collectable> collection);


    }
}
