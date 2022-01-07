using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ce103_hw5_mehmet_alpergun;

namespace ce103_hw5_snake_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            appclass snake = new appclass();
            snake.main();
        }
    }
}
