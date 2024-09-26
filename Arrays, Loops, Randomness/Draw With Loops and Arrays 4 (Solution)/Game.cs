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
        float[] xs = [];
        float[] ys = [];
        float[] radii = [];
        Color[] colors = [];

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Draw With Loops and Arrays #4");
            Window.SetSize(400, 400);

            // Prepare arrays
            xs = new float[10];
            ys = new float[10];
            radii = new float[10];
            colors = new Color[10];
            // Loop over each item and assign a random value
            for (int i = 0; i < colors.Length; i++)
            {
                xs[i] = Random.Float(0, 400);
                ys[i] = Random.Float(0, 400);
                radii[i] = Random.Float(10, 40);
                colors[i] = Random.Color();
            }
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            // run loop 10 times
            for (int i = 0; i < 10; i++)
            {
                // Get value
                float x = xs[i]; // Get X from array
                float y = ys[i]; // Get Y from arary
                float radius = radii[i]; // Get radius from arary
                Color color = colors[i]; // Get color from arary
                // Draw with random values
                Draw.FillColor = color;
                Draw.Circle(x, y, radius);
            }

        }
    }
}
