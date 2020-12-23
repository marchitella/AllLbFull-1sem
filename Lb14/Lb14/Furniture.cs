using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb14
{
    [Serializable]
    public abstract class Furniture
    {
        public string Color { get; set; }
        public virtual void ColorOf()
        {
            Console.WriteLine("Цвет стола - " + Color);
        }
        public abstract void resize();
        public Furniture(string color)
        {
            this.Color = color;
        }
        public Furniture()
        {
        }
        public override string ToString()
        {
            return $"Объект типа {this.GetType()}";
        }

    }
}
