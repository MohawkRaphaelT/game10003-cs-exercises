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
        float[] xs    = [108, 095, 216, 359, 074, 271, 202, 330, 146, 252];
        float[] ys    = [062, 346, 240, 026, 177, 341, 322, 234, 151, 078];
        float[] radii = [012, 027, 034, 022, 010, 040, 028, 011, 016, 012];

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Draw With Loops and Arrays #2");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
            Draw.FillColor = Color.Red;

            // Note: xs and ys count need to match for this to work!
            int numberOfPoints = xs.Length;
            for (int i = 0; i < numberOfPoints; i++)
            {
                float x = xs[i]; // Get X from array
                float y = ys[i]; // Get Y from arary
                float radius = radii[i]; // Get radius from arary
                Draw.Circle(x, y, radius);
            }

        }
    }
}
