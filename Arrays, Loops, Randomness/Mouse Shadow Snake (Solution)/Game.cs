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
        int circleCount;
        Color[] colors = [];
        float[] radii = [];
        float[] xCoordinates = [];
        float[] yCoordinates = [];

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Mouse Shadow Snake");
            Window.SetSize(400, 400);
            Draw.LineSize = 0;

            // Make twice as many capsules as there are frames in a second.
            // This makes the animation last the same amount of time.
            circleCount = Window.TargetFPS * 2;

            // Make arrays the right size
            colors = new Color[circleCount];
            radii = new float[circleCount];
            xCoordinates = new float[circleCount];
            yCoordinates = new float[circleCount];

            // Create grayscale colors and radii
            for (int i = 0; i < circleCount; i++)
            {
                int intensity = 255 - (i * 256 / circleCount);
                colors[i] = new Color(intensity);
                radii[i] = i / (float)circleCount * 35;
            }
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Prepare for drawing
            Window.ClearBackground(Color.OffWhite);

            // Low indexes = older, high indexes = newer.
            // Set lower indexes to the value of higher ones.
            // Loop ends one value prematurely, other indexing errors.
            for (int i = 0; i < circleCount - 1; i++)
            {
                xCoordinates[i] = xCoordinates[i + 1];
                yCoordinates[i] = yCoordinates[i + 1];
            }
            // Set last index to curren mouse position.
            xCoordinates[circleCount - 1] = Input.GetMouseX();
            yCoordinates[circleCount - 1] = Input.GetMouseY();

            // Likewise, loop through all but last since we are
            // drawing capsules between points.
            for (int i = 0; i < circleCount - 1; i++)
            {
                float x0 = xCoordinates[i + 0];
                float y0 = yCoordinates[i + 0];
                float x1 = xCoordinates[i + 1];
                float y1 = yCoordinates[i + 1];
                Draw.FillColor = colors[i + 1];
                Draw.Capsule(x0, y0, x1, y1, radii[i]);
            }
        }
    }
}
