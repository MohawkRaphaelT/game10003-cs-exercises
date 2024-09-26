// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Draw Gradient With Loop");
            Window.SetSize(400, 400);
            Draw.LineSize = 1;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Prepare for drawing
            Window.ClearBackground(Color.OffWhite);

            // Loop over each X coordinate
            for (int x = 0; x < Window.Width; x++)
            {
                // On a scale of 0-256, figure out where we are
                int percentage = x * 256 / Window.Width;
                // Use that value as a color (intensity)
                Color color = new Color(percentage);
                // Draw a line from top to bottom at the x coordinate with that color
                Draw.LineColor = color;
                Draw.Line(x, 0, x, Window.Height);
            }
        }
    }
}
