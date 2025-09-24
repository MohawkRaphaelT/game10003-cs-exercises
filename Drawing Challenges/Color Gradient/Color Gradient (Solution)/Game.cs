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
            // Calculate red as a percentage of the screen
            // If mouseX is   0, then   0/400 is 0.0f, no red
            // If mouseX is 400, the, 400/400 is 1.0f, full red
            float r = Input.GetMouseX() / Window.Width;
            
            // Calculate red as a percentage of the screen
            // If mouseY is   0, then   0/400 is 0.0f, no green
            // If mouseY is 400, the, 400/400 is 1.0f, full green
            float g = Input.GetMouseY() / Window.Height;
            
            // This challenge does not expect you to set the B color channel.
            float b = 0.0f;

            // Combine the 3 color components we defined above
            ColorF bgColor = new ColorF(r, g, b);

            // Clear the background with this color
            Window.ClearBackground(bgColor);
        }
    }
}
