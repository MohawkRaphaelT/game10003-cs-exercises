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
            Window.SetTitle("Draw 2D Gradient With Loops");
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

            // 
            float yCoordinate = Window.Height / 2;
            for (int i = 0; i < 8; i++)
            {
                float xCoordinate = 25 + i * 50;
                Draw.Circle(xCoordinate, yCoordinate, 25);
            }
        }

    }
}
