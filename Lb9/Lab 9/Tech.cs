using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9
{
    class Tech
    {
        public int EventReaction { get; private set; }
        public void OnUpgrading(string str)
        {
            Console.WriteLine($"{str} : замечено техникой ");
            EventReaction++;
        }
        public void OnTurningOn(string str)
        {
            Console.WriteLine($"{str} : замечено техникой ");
            EventReaction++;
        }
    }
    class SemiTech
    {
        public int EventReaction { get; private set; }

        public void OnUpgrading(string str)
        {
            Console.WriteLine($"{str} : замечено полу-техникой ");
            EventReaction++;

        }
    }

}
