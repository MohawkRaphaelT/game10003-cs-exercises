// CHALLENGE: have the background color change based on the mouse's position.
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
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            // Set up window
            Window.SetTitle("Color Gradient");
            Window.SetSize(256, 256);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // We use the mouse position as if it were a color value!
            Window.ClearBackground(Input.GetMouseX(), Input.GetMouseY(), 0);
        }
    }
}
