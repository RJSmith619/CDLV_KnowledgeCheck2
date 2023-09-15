using System;
using CDLV_KnowledgeCheck2;

namespace CDLV_KnowledgeCheck2
{
    public class Cat : Animal
    {
        public string FurColor { get; set; }

        public void Meow()
        {
            Console.WriteLine("Meow!");
        }

    }
}

