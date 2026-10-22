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
        Window.SetTitle("Sunset");
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

        // Sun reflection on ocean
        Draw.LineSize = 1;
        Draw.FillColor = beige;

        // Computing width of circle per raster line
        // This program borrows and modifies this idea
        // https://www.redblobgames.com/grids/circle-drawing/
        int topY = 450 - (mouseY / 2) - (radius / 2);
        int botY = topY + radius;
        float deltaY = botY - topY;
        // Calculate percentage proximity to horizon
        // When pLo=0, pHi=1, when pLo=1, pHi=0.
        // When pLo is 1, sun is at mouse position on horizon
        // When pHi is 1, sun is offset from mouseX position
        float pLo = MathF.Max(MathF.Min(mouseY / 300f, 1f), 0f);
        float pHi = 1f - pLo;
        float centreX = (mouseX * pLo) + ((mouseX - 100) * pHi);
        // Ripple effect
        float rippleSpeed = 5f; // cycles once every 5 seconds
        float rippleWidth = 20f; // modify width of ripples
        float rippleSway = 30f; // sway move lines side to side
        // Loop that draws each line
        for (int y = /***/; y <= /***/; /***/)
        {

            // Time in the range of 0-1 only
            float time01 = Time.SecondsElapsed / rippleSpeed % 1;
            // Calculate some values to distort the lines drawn to create the reflection effect
            float widthOffsetTime = y / 6.65f; // bigger = soft, smaller = jagged
            float swayOffsetTime = y / 2.5f;  // bigger number = smoother warping
            float widthOffsetX = MathF.Sin(time01 * MathF.Tau + widthOffsetTime) * rippleWidth;
            //widthOffsetX = 0; // Uncomment to isolate other effect
            float lineOffsetX = MathF.Sin(time01 * MathF.Tau + swayOffsetTime) * rippleSway;
            //lineOffsetX = 0; // Uncomment to isolate other effect

            // Continuation of the aforementioned blog post
            float dy = y * 2f - deltaY;
            float dx = MathF.Sqrt((radius * radius) - (dy * dy)) + widthOffsetX;
            float left = centreX - dx + lineOffsetX;
            float right = centreX + dx + lineOffsetX;
            Draw.Line(left, 350, right, 350);
        }
    }
}
