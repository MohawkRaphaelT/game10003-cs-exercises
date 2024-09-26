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
        int radius = 35;
        int[] drawIndexes = [ 0, 2, 4 ];
        Color[] colors = [ Color.Red, Color.Blue, Color.Green ];
        float[] xCoorindates = [100, 200, 300, 100, 200, 300, 100, 200, 300];
        float[] yCoorindates = [100, 100, 100, 200, 200, 200, 300, 300, 300];

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Draw Selected From Array 3");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Prepare for drawing
            Window.ClearBackground(Color.OffWhite);
            Draw.LineSize = 3;

            // Draw all circles first
            Draw.FillColor = Color.Gray;
            for (int i = 0; i < 9; i++)
            {
                Draw.Circle(xCoorindates[i], yCoorindates[i], radius);
            }

            // Increment index if input is pressed
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space) ||
                Input.IsMouseButtonPressed(MouseInput.Left))
            {
                for (int i = 0; i < drawIndexes.Length; i++)
                {
                    // Increment index inside of array
                    drawIndexes[i]++;
                    // Wrap value around
                    if (drawIndexes[i] >= 9)
                        drawIndexes[i] = 0;
                    // Wrap value in one line by using assign-remainder!
                    //drawIndexes[i] %= 9;
                }
            }

            // Draw each selected circle
            for (int i = 0; i < drawIndexes.Length; i++)
            {
                Draw.FillColor = colors[i];
                int drawIndex = drawIndexes[i];
                float x = xCoorindates[drawIndex];
                float y = yCoorindates[drawIndex];
                Draw.Circle(x, y, radius);
            }
        }
    }
}
