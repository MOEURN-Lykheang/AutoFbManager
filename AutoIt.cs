using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;
namespace AutoFbManager
{
    class AutoIt
    {
        AutoItX3 auto = new AutoItX3();

        public void MyClick(string clickSide, int x, int y , int manyClick , int speed)
        {
            auto.MouseClick(clickSide, x, y, manyClick, speed);
        }
    }
}
