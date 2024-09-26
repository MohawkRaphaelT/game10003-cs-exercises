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
            Window.SetTitle("Draw Steps With Loop");
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
            Draw.FillColor = Color.Gray;

            // Loop 10 times (10 steps)
            for (int i = 0; i < 10; i++)
            {
                // Calculate upper-left coordinates
                int xCoordinate = i * 40;      // space x 40 pixels
                int yCoordinate = i * 30 + 50; // space y 30 pixels, starting at y of 50

                // Draw using coordinates, and overdraw below screen
                Draw.Rectangle(xCoordinate, yCoordinate, 40, 400);
            }

        }
    }
}
