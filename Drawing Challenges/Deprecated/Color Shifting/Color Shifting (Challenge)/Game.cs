// CHALLENGE: have the background color change over time
// Hint: how can you make the program remember the last color?

// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D;

public class Game
{
    public void Setup()
    {
        Window.SetTitle("Color Shifting");
        Window.SetSize(400, 400);
        // Run this one slow so the colors don't change too fast
        Window.TargetFPS = 10;
    }

    public void Update()
    {
        // Create a color
        int r = 0;
        int g = 0;
        int b = 0;
        Color color = new Color(r, g, b);

        // Set the background color every frame
        Window.ClearBackground(color);
    }
}
