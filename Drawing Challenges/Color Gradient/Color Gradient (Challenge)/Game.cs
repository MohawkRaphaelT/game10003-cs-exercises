// CHALLENGE: have the background color change based on the
//            mouse's position.
// Hint: translate position into color.

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


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            // Set up window
            Window.SetTitle("Color Gradient");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Calculate red
            float r = 1.0f;
            // Leave g and b as 0. You could set this to anything you would like.
            float g = 0.0f;
            float b = 0.0f;

            // Combine the 3 color components
            ColorF bgColor = new ColorF(r, g, b);

            // Clear the background with this color
            Window.ClearBackground(bgColor);
        }
    }
}
