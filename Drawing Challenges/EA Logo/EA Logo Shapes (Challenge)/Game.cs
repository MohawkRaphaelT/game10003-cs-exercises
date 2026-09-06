// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("EA Logo 1982");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //
            Window.ClearBackground(240);
            Draw.Circle(200, 200, 75);

            //
            Draw.SetLineSize(0);
            Draw.SetFillColor("0490c7");
            Draw.Square(20, 125, 150);

            //
            Draw.SetFillColor(0);
            Draw.SetLineColor(240);
            Draw.SetLineSize(10);
            Draw.Line(0, 135, 400, 135);
            Draw.SetLineSize(9);
            Draw.Line(0, 150, 400, 150);
            Draw.SetLineSize(8);
            Draw.Line(0, 165, 400, 165);
            Draw.SetLineSize(7);
            Draw.Line(0, 180, 400, 180);
            Draw.SetLineSize(6);
            Draw.Line(0, 195, 400, 195);
            Draw.SetLineSize(5);
            Draw.Line(0, 210, 400, 210);
            Draw.SetLineSize(4);
            Draw.Triangle(200, 275, 380, 275, 290, 125);
            Draw.Line(0, 225, 400, 225);
            Draw.SetLineSize(3);
            Draw.Line(0, 240, 400, 240);
            Draw.SetLineSize(2);
            Draw.Line(0, 255, 400, 255);
        }
    }

}
