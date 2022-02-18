using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;//задаем пространство имен

namespace Lab3WpfApp4
{
    class MyCommands
    {
        public static RoutedCommand Close { get; set; } // задаем команду "Закрыть"
        
        static MyCommands() // в статическом конструкторе инициализируем команду
        {
            InputGestureCollection inputs = new InputGestureCollection();//коллекция жестов
            inputs.Add(new KeyGesture(Key.Z, ModifierKeys.Control,"Ctrl+Z"));
            Close = new RoutedUICommand("Закрыть","Close", typeof(MyCommands), inputs);// RoutedUICommand -это текстовое название команды
            // если будет вот так  ("Close", typeof(MyCommands), inputs), тогда будет выводить на английском в пункте меню
        }
    }
}
