// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

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
            Window.SetTitle("Draw Checkerboard With Loops");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Prepare for drawing
            Window.ClearBackground(Color.OffWhite);

            // Compute cell width and height
            int width = Window.Height / 8;
            int height = Window.Height / 8;

            // Iterate over rows
            for (int y = 0; y < 8; y++)
            {
                // Compute y coordinate of cells in this row
                int yCoordinate = y * height;

                // Iterate over columns
                for (int x = 0; x < 8; x++)
                {
                    // Compute  x coordinate of cells in this column
                    int xCoordinate = x * width;

                    // Sum x/y coordinate, take remainder of that divided by 2
                    // If 0, draw white, if 1, draw black
                    // This makes sense if you work out each values by hand for
                    // a small grid of eg. 4x4!
                    bool isBlack = (x + y) % 2 == 0;
                    if (isBlack)
                        Draw.FillColor = Color.Black;
                    else
                        Draw.FillColor = Color.White;

                    // Finally draw the rectangle
                    Draw.Rectangle(xCoordinate, yCoordinate, width, height);
                }
            }
        }
    }
}
