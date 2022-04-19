using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace Turtlepie
{
    class Program
    {
        static void WriteSh()
        {
            Turtle.Angle = 0;
            Turtle.Move(40);
            Turtle.Turn(180);
            Turtle.Move(40);
            Turtle.TurnLeft();
            Turtle.Move(20);
            Turtle.TurnLeft();
            Turtle.Move(20);
            Turtle.Turn(180);
            Turtle.Move(20);
            Turtle.TurnLeft();
            Turtle.Move(20);
            Turtle.TurnLeft();
            Turtle.Move(40);
        }
        static void Writea()
        {
            Turtle.Angle = 20;
            Turtle.Move(40);
            Turtle.Turn(140);
            Turtle.Move(40);
            Turtle.Turn(180);
            Turtle.Move(20);
            Turtle.Turn(-70);
            Turtle.Move(20);
        }
        static void WriteD()
        {
            Turtle.Angle = 0;
            Turtle.Move(10);
            Turtle.TurnRight();
            Turtle.Move(10);
            WriteO();
            Turtle.TurnRight();
            Turtle.Move(40);
            Turtle.TurnRight();
            Turtle.Move(10);
        }
        static void WriteT(double n)
        {
            Turtle.Angle = 0;
            Turtle.Move(n*60);
            Turtle.TurnLeft();
            Turtle.Move(n*20);
            Turtle.Angle = 90;
            Turtle.Move(n*40);
        }

        static void WriteO()
        {
            Turtle.Angle = 0;
            for(int i = 0; i < 4; i++ )
            {
                Turtle.Move(30);
                Turtle.TurnRight();
            }
        }

        static void WriteP()
        {
            Turtle.Angle = 0;
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(30);
                Turtle.TurnRight();
            }
            Turtle.Angle =180;
            Turtle.Move(30);
        }

        static void Main(string[] args)
        {


            Turtle.Speed = 8;
            Turtle.X = 200;
            Turtle.Y = 200;
            WriteD();
            Turtle.X = 260;
            Turtle.Y = 200;
            Writea();
            Turtle.X = 300;
            Turtle.Y = 200;
            WriteSh();
            Turtle.X = 350;
            Turtle.Y = 200;
            Writea();
            Turtle.X = 200;
            Turtle.Y = 300;
            WriteT(1);
            Turtle.X = 240;
            Turtle.Y = 300;
            WriteO();
            Turtle.X = 300;
            Turtle.Y = 300;
            WriteP();
            Turtle.X = 360;
            Turtle.Y = 300;
            WriteT(0.5);
            Turtle.Hide();

        }
    }
}
