using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb6
{
    class PP : IEnumerable
    {
        private TelevisionProgram _first;
        private TelevisionProgram _last;
        private int _count = 0;
        TelevisionProgram [] Elements;//Для обращения к элементу по его индексу
        public PP(TelevisionProgram firstElement)
        {
            Elements = new TelevisionProgram[1];
            Elements[0] = firstElement;
            _first = firstElement;
            _last = firstElement;
            _count++;
        }
        public PP(params TelevisionProgram[] Element)
        {
            Elements = new TelevisionProgram[Element.Length];
            _first = Element[0];
            _last = Element[0];
            for (; _count < Element.Length; _count++)
            {
                Elements[_count] = Element[_count];
                _last.Next = Element[_count];
                _last = Element[_count];
            }
        }
        public void Add(TelevisionProgram nextElement)
        {
            Array.Resize(ref Elements, Elements.Length + 1);
            Elements[_count] = nextElement;
            _last.Next = nextElement;
            _last = nextElement;
            _count++;
        }
        public void Show()
        {
            TelevisionProgram Element = this._first;
            do
            {
                Element.Status();
                Element = Element.NextElement();
            } while (Element != this._last);
            Element.Status();
        }
        public void Show(int index)
        {
            TelevisionProgram Element = this._first;
            while (Element != Elements[index])
            {
                Element = Element.NextElement();
            }
            Element.Status();
        }
        public void DeleteLast()
        {
            TelevisionProgram Element = this._first;
            while (Element.NextElement() != this._last)
            {
                Element = Element.NextElement();
            }
            Element.Next = Element;
            this._last = Element;
            _count--;
        }
        public void Delete(int index)
        {
            if (index == 0)
            {
                _first = Elements[1];
                Elements[0] = Elements[1];
                Refresh();
            }
            else if (index == _count - 1)
            {
                DeleteLast();

            }
            else
            {
                Elements[index - 1].Next = Elements[index + 1];
                Refresh();
            }
        }
        private void Refresh()
        {
            TelevisionProgram Element = _first;
            int index = 0;
            while (Element.NextElement() != this._last)
            {
                Elements[index] = Element;
                index++;
                Element = Element.NextElement();
            }
            _count--;
        }
        public IEnumerator GetEnumerator()
        {
            return Elements.GetEnumerator();
        }

        public int this[int index]//Перегрузки индексаторов
        {
            get => index;
            set => index = value;
        }



    }
}
