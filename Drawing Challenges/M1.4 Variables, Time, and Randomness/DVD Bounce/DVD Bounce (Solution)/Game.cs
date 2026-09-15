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
        float positionY;
        bool isTravelingRight;
        bool isTravelingDown;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("DVD Bounce");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(240);

            // Check if we hit the right screen edge
            if (positionX >= Window.Width - 60)
            {
                isTravelingRight = false;
            }
            // Check if we hit the left screen edge
            if (positionX <= 0)
            {
                isTravelingRight = true;
            }
            // Check if we hit the bottom screen edge
            if (positionY >= Window.Height - 30)
            {
                isTravelingDown = false;
            }
            // Check if we hit the top screen edge
            if (positionY <= 0)
            {
                isTravelingDown = true;
            }

            // Move the rectangle along X-axis
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

            // Move the rectangle along Y-axis
            if (isTravelingDown == true)
            {
                // Move at a rate of 200 pixels per second to the right
                positionY += 200 * Time.DeltaTime;
            }
            else // is traveling up
            {
                // Move at a rate of 200 pixels per second to the left
                positionY -= 200 * Time.DeltaTime;
            }

            // Draw "DVD" rectangle
            Draw.SetFillColor(255, 0, 0);
            Draw.Rectangle(positionX, positionY, 60, 30);
        }
    }

}
