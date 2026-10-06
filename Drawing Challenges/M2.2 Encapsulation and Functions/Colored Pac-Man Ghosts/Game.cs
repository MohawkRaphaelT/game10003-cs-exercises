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
        Color yellow = new(248, 255, 9);
        Color red = new(255, 0, 0);
        Color pink = new(255, 184, 255);
        Color cyan = new(0, 255, 255);
        Color orange = new(255, 184, 82);
        Color blue = new(33, 33, 222);
        Color white = new(255);


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Colored Pac-Man Ghosts");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(0);

            // Pac-Man
            Draw.FillColor = yellow;
            Draw.Arc(80, 200, 90, 90, 30, 330);

            DrawGhost(230, 120, red);
            DrawGhost(325, 170, pink);
            DrawGhost(240, 240, cyan);
            DrawGhost(340, 290, orange);
        }

        public void DrawGhost(int x, int y, Color color)
        {
            Draw.LineSize = 0;

            // Ghost Body
            Draw.FillColor = color;
            int radius = 40;
            Draw.Circle(x, y, radius);
            Draw.Rectangle(x - radius, y, radius * 2, radius);
            int bottomY = y + radius;
            // Left, right, centre
            Draw.Triangle(x - radius, bottomY, x - radius * 0.33f, bottomY, x - radius * 0.67f, bottomY + radius / 3);
            Draw.Triangle(x + radius, bottomY, x + radius * 0.33f, bottomY, x + radius * 0.67f, bottomY + radius / 3);
            Draw.Triangle(x - radius * 0.33f, bottomY, x + radius * 0.33f, bottomY, x, bottomY + radius / 3);

            // Eyes
            Draw.FillColor = white;
            Draw.Ellipse(x - radius / 1.7f, y, radius * 0.66f, radius * 1f);
            Draw.Ellipse(x + radius / 3.0f, y, radius * 0.66f, radius * 1f);
            Draw.FillColor = blue;
            Draw.Circle(x - radius / 1.38f, y + radius / 10f, radius * 0.2f);
            Draw.Circle(x + radius / 5.0f, y + radius / 10f, radius * 0.2f);
        }
    }

}
