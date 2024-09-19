// CHALLENGE: have the background color change over time
// Hint: how can you make the program remember the last color?

using System;
using System.Numerics;

namespace Game10003;

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
