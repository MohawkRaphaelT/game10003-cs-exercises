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
        // Start lines at 300 Y towards bottom of screen
        // But also offset first line by line thickness
        float linePosY = 300 + lineCount / 2;
        for (int i = 0; i < lineCount; i++)
        {
            float lineSize = lineCount - i;
            Draw.LineSize = lineSize;
            Draw.Line(0, linePosY, 400, linePosY);
            linePosY -= lineCount;
        }

        // Upper horizon lines
        Draw.LineColor = red;
        // Start lines in centre of first line thickness
        linePosY = lineCount / 2;
        for (int i = 0; i < lineCount; i++)
        {
            float lineSize = lineCount - i;
            Draw.LineSize = lineSize;
            Draw.Line(0, linePosY, 400, linePosY);
            linePosY += lineCount;
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
