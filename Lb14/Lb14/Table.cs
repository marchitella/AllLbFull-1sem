using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lb14
{
    [Serializable]
    public class Table : Furniture
    {
        public int length { get; set; }

        public override void resize()
        {
            length++;
            this.show();
        }
        public void show()
        {
            Console.WriteLine("Длина стола = " + length);
        }
        public void input(int len)
        {
            len = len;
            this.show();
        }
        public Table(string color, int length) : base(color)
        {
            this.length = length;
            this.Color = color;
        }
        public Table()
        {
        }
    }
}
