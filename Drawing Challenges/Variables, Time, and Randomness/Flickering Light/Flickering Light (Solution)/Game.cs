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
        bool isLightOn;
        float timeLeft;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Flickering Light");
            Window.SetSize(400, 400);
            Draw.SetLineSize(6);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Toggle light
            timeLeft -= Time.DeltaTime;
            if (timeLeft <= 0)
            {
                // Logically inverse Boolean
                if (isLightOn == true)
                {
                    isLightOn = false;
                }
                else // isLightOn == false
                {
                    isLightOn = true;
                }

                // Reset timer
                timeLeft = Random.Float(0.1f, 1.0f);
            }

            // if light on
            if (isLightOn)
            {
                // Light background
                Window.ClearBackground(240);
                // Yellow
                Draw.SetFillColor(255, 255, 0);
            }
            else // light off
            {
                // Light background
                Window.ClearBackground(60);
                // Dark Grey
                Draw.SetFillColor(120);
            }

            // Draw lightbulb
            Draw.Line(200, 0, 200, 200);
            Draw.Circle(200, 200, 100);
        }
    }

}
