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
        int cells = 20;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Draw 2D Gradient With Loops");
            Window.SetSize(400, 400);
            Draw.LineSize = 0;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Prepare for drawing
            Window.ClearBackground(Color.OffWhite);

            int cellCount = 20;
            int cellSizeX = Window.Width / cellCount;
            int cellSizeY = Window.Height / cellCount;

            // Loop over X cell (horizontal)
            for (int x = 0; x < cellCount; x++)
            {
                // On a scale of 0-256
                int xColor = x * 256 / cellCount;

                // Loop over Y cells (vertical)
                for (int y = 0; y < cellCount; y++)
                {
                    // On a scale of 0-256, figure out where we are
                    int yColor = y * 256 / cellCount;
                    // Create color from X and Y positions
                    Color color = new Color(xColor, yColor, 0);
                    // Draw a rectangle at this x/y cell
                    Draw.FillColor = color;
                    Draw.Rectangle(x * cellSizeX, y * cellSizeY, cellSizeX, cellSizeY);
                }
            }
        }
    }
}
