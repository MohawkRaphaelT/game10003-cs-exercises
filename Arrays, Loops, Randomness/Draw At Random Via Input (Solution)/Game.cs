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
        float x;
        float y;
        float radius = 35;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Draw At Random Via Input");
            Window.SetSize(400, 400);

            // Compute screen center coordinate
            x = Window.Width / 2;
            y = Window.Height / 2;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Prepare for drawing
            Window.ClearBackground(Color.OffWhite);

            // Increment index
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space) ||
                Input.IsMouseButtonPressed(MouseInput.Left))
            {
                Draw.FillColor = Random.Color();
                radius = Random.Float(10, 100);
                x = Random.Float(radius, Window.Width - radius);
                y = Random.Float(radius, Window.Height - radius);
            }

            // Draw circle
            Draw.Circle(x, y, radius);
        }
    }
}
