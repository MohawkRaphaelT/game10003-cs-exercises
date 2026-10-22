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
    // Colours from: https://lospec.com/palette-list/ice-cream-gb
    Color wine = new("7c3f58");
    Color red = new("eb6b6f");
    Color orange = new("f9a875");
    Color beige = new("fff6d3");


    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()
    {
        Window.SetTitle("Sunset Simple");
        Window.SetSize(400, 400);
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        Window.ClearBackground(orange);
        int mouseX = Input.GetMouseX();
        int mouseY = Input.GetMouseY();
        int radius = 80;
        int lineCount = 12;

        // Lower horizon lines
        Draw.LineColor = beige;
        for ()
        {

        }

        // Upper horizon lines
        Draw.LineColor = red;
        for ()
        {

        }

        // Sun
        Draw.LineSize = 0;
        Draw.FillColor = beige;
        Draw.Circle(mouseX, mouseY, radius);

        // Ocean
        Draw.LineSize = 0;
        Draw.FillColor = wine;
        Draw.Rectangle(0, 300, 400, 100);
    }
}
