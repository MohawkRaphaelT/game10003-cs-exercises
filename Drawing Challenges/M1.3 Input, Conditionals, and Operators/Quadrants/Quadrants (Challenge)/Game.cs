// CHALLENGE: Quadrants
// Only draw the colored squared when the mouse is inside that quadrant.
// Thus, only 1 color is draw on screen at one time.

// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D;

public class Game
{
    public void Setup()
    {
        Window.SetTitle("Quadrants");
        Window.SetSize(400, 400);
    }

    public void Update()
    {
        // Clear screen
        Window.ClearBackground(240);

        // Top-Left, red
        Draw.SetFillColor(255, 0, 0);
        Draw.Square(0, 0, 200);

        // Top-Right, green
        Draw.SetFillColor(0, 255, 0);
        Draw.Square(200, 0, 200);

        // Bottom-Left, yellow
        Draw.SetFillColor(255, 255, 0);
        Draw.Square(0, 200, 200);

        // Bottom-Right, blue
        Draw.SetFillColor(0, 0, 255);
        Draw.Square(200, 200, 200);

        // Draw lines to separate screen into quadrants
        Draw.SetLineSize(2);
        Draw.LineSharp(Window.Width / 2, 0, Window.Width / 2, Window.Height);
        Draw.LineSharp(0, Window.Height / 2, Window.Width, Window.Height / 2);
        Draw.SetLineSize(0);
    }
}
