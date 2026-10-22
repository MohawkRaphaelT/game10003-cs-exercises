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
    // Colors from: https://lospec.com/palette-list/kirokaze-gameboy
    Color navy = new("332c50");
    Color blue = new("46878f");
    Color green = new("94e344");
    Color ice = new("e2f3e4");

    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()
    {
        Window.SetTitle("Moon over Clouds");
        Window.SetSize(400, 400);
        Draw.LineSize = 0;
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        // Sky
        Window.ClearBackground(navy);

        // TODO: stars
        // Use arrays

        // Moon
        Draw.FillColor = ice;
        Draw.Circle(300, 100, 50);
        // Big crater
        Draw.FillColor = green;
        Draw.Circle(282, 85, 20);
        Draw.FillColor = ice;
        Draw.Circle(284, 87, 19);
        // Small craters
        Draw.FillColor = green;
        Draw.Circle(270, 120, 5);
        Draw.Circle(328, 125, 5);
        Draw.Circle(322, 132, 3);
        Draw.Ellipse(304, 60, 25, 10);
        Draw.FillColor = ice;
        Draw.Circle(271, 120, 4);
        Draw.Circle(327, 124, 4);
        Draw.Circle(320, 131, 3);
        Draw.Ellipse(305, 61, 23, 8);

        // Background
        Draw.FillColor = blue;
        for (int x = 0; x <= Window.Width; x += 33)
        {
            Draw.Circle(x, Window.Height - 145, 33);
        }

        // Midground
        Draw.FillColor = green;
        for (int x = 0; x <= Window.Width; x += 66)
        {
            Draw.Circle(x, Window.Height - 80, 67);
        }

        // Foreground
        Draw.FillColor = ice;
        for (int x = 0; x <= Window.Width; x += 100)
        {
            Draw.Circle(x, Window.Height, 100);
        }
    }
}
