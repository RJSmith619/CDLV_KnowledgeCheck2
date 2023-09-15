using System;
namespace CDLV_KnowledgeCheck2
{
    public class Animal
    {

        public string Name { get; set; }
        public decimal Age { get; set; }
        public decimal Weight { get; set; }


        public void eat()
        {
            Console.WriteLine("Animal is eating");
        }

        public void sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }

    }
}

