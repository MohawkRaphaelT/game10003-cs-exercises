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
            Window.SetTitle("Draw Shape Line With Loop");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Prepare for drawing
            Window.ClearBackground(Color.OffWhite);
            Draw.FillColor = Color.Green;

            // Set y to fixed coordinate in centre of screen
            float yCoordinate = Window.Height / 2;
            // Loop over 8 times to compute an X coordinate
            for (int i = 0; i < 8; i++)
            {
                float xCoordinate = 25 + i * 50;
                Draw.Circle(xCoordinate, yCoordinate, 25);
            }
        }

    }
}
