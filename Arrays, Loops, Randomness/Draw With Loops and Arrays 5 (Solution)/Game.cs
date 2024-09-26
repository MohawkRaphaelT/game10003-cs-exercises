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
        int count;
        float[] xs = [];
        float[] ys = [];
        float[] radii = [];
        Color[] colors = [];

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Draw With Loops and Arrays #5");
            Window.SetSize(400, 400);

            // Prepare arrays
            count = Random.Integer(5, 50);
            xs = new float[count];
            ys = new float[count];
            radii = new float[count];
            colors = new Color[count];
            // Loop over each item and assign a random value
            for (int i = 0; i < count; i++)
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

            // run loop 'count' times
            for (int i = 0; i < count; i++)
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
