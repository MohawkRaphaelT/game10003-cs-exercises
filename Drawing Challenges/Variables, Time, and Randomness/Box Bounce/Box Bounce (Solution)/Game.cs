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
        // Place your variables here:
        float positionX;
        bool isTravelingRight;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Box Bounce");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(240);

            // Check if we hit the right screen edge
            if (positionX >= Window.Width - 40)
            {
                isTravelingRight = false;
            }
            // Check if we hit the left screen edge
            if (positionX <= 0)
            {
                isTravelingRight = true;
            }

            // Move the square
            if (isTravelingRight == true)
            {
                // Move at a rate of 200 pixels per second to the right
                positionX += 200 * Time.DeltaTime;
            }
            else // is traveling right
            {
                // Move at a rate of 200 pixels per second to the left
                positionX -= 200 * Time.DeltaTime;
            }

            // Draw box
            Draw.SetFillColor(255, 0, 0);
            Draw.Square(positionX, 180, 40);
        }
    }

}
