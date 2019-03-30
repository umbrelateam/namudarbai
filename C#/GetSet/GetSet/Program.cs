using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Таким образом вы можете полностью контролировать операции получения каких - то свойств или их изменения:
//Контролировать изменяемые значения
//Выбрасывать исключения
//Вызывать события
//Много чего еще.


namespace GetSet
{
    class Light
    {
        private bool _isOn = false;
        private bool _isOff = true;

        public bool ON
        {
            get { return _isOn; }
            set
            {
                _isOn = value;
                _isOff = !value;
            }
        }

        public bool OFF
        {
            get { return _isOff; }
            set
            {
                _isOff = value;
                _isOn = !value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
