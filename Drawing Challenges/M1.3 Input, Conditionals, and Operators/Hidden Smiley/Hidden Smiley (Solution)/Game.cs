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
            Window.SetTitle("Hidden Smiley");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Clear screen
            Window.ClearBackground(128);

            // Draw face circle in yellow
            Draw.SetLineSize(0);
            Draw.SetFillColor(255, 255, 0);
            Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 100);

            // Smiley drawn with same colour as background
            Draw.SetLineSize(20);
            Draw.SetLineColor(128);
            Draw.SetFillColor(128);
            Draw.Arc(200, 200, 100, 100, 0, 180);
            Draw.Circle(200 - 60, 180, 10);
            Draw.Circle(200 + 60, 180, 10);
        }
    }

}
