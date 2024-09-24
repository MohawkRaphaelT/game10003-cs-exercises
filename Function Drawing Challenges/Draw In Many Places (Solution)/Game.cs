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
        Color bg = new Color(0, 161, 224);
        Color frogGreen = new Color(140, 240, 110);
        Color frogBrown = new Color(150, 115, 75);
        Color frogPink = new Color(255, 170, 150);

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Draw In Many Places");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(bg);

            float x = Input.GetMouseX();
            float y = Input.GetMouseY();

            // Draw in upper-left corner
            DrawFrog(90, 120);
            // Draw in upper-left corner
            DrawFrog(310, 380);
            // Draw at mouse position
            DrawFrog(x, y);
            // Draw beside mouse position
            DrawFrog(x + 120, y + 25);
        }

        void DrawFrog(float x, float y)
        {
            Draw.LineSize = 0;
            // Body and eyes (green)
            Draw.FillColor = frogGreen;
            Draw.Circle(x - 25, y - 70, 23);
            Draw.Circle(x + 25, y - 70, 23);
            Draw.Capsule(x - 50, y - 40, x + 50, y - 40, 25);
            // Feet
            //Draw.FillColor = frogBrown;
            Draw.Square(x - 20, y - 15, 15); // L
            Draw.Square(x + 05, y - 15, 15); // L
            Draw.Rectangle(x - 40, y - 12, 32, 12); // L
            Draw.Rectangle(x + 05, y - 12, 32, 12); // R
            Draw.Circle(x - 40, y - 6, 6); // L
            Draw.Circle(x + 39, y - 6, 6); // R
            // Cheeks
            Draw.FillColor = frogPink;
            Draw.Circle(x - 50, y - 40, 22);
            Draw.Circle(x + 50, y - 40, 22);
            // Eyes
            Draw.FillColor = Color.White;
            Draw.Circle(x - 25, y - 70, 18);
            Draw.Circle(x + 25, y - 70, 18);
            Draw.FillColor = Color.Black;
            Draw.Circle(x - 25, y - 70, 10);
            Draw.Circle(x + 25, y - 70, 10);
            // Mouth
            Draw.LineSize = 3;
            Draw.LineColor = Color.Black;
            Draw.PolyLine(x - 15, y - 40, x, y - 25, x + 15, y - 40);
        }
    }
}
