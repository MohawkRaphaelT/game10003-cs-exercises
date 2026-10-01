// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D;

/// <summary>
///     Your game code goes inside this class!
/// </summary>
public class Game
{
    // Place your variables here:
    ColorF color0;
    ColorF color1;

    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()
    {
        Window.SetTitle("Random Colour Gradient");
        Window.SetSize(400, 400);
        Draw.LineSize = 1;
        color0 = Random.Color();
        color1 = Random.Color();
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        // Prepare for drawing
        Window.ClearBackground(Color.OffWhite);

        if (Input.IsMouseButtonPressed(MouseButton.Left))
        {
            color0 = Random.Color();
            color1 = Random.Color();
        }

        // Loop over each X coordinate
        for (int x = 0; x <= Window.Width; x++)
        {
            // Get a percentage p
            // left-to-right (p0)
            // right to left (p1)
            float p0 = x / 400f;
            float p1 = (400 - x) / 400f;

            // Combine colours linearly
            float r = color0.R * p0 + color1.R * p1;
            float g = color0.G * p0 + color1.G * p1;
            float b = color0.B * p0 + color1.B * p1;
            ColorF color = new ColorF(r, g, b);
            Draw.LineColor = color;
            Draw.Line(x, 0, x, Window.Height);
        }
    }
}
