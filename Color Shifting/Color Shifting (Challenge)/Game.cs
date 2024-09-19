// CHALLENGE: have the background color change over time
// Hint: how can you make the program remember the last color?

using System;
using System.Numerics;

namespace Game10003;

public class Game
{
    // Keep track of color variables
    Color color = new Color();

    public void Setup()
    {
        Window.SetTitle("Color Shifting");
        Window.SetSize(400, 400);
        // Run this one slow so the colors don't change too fast
        Window.TargetFPS = 10;
    }

    public void Update()
    {
        // Update the color every frame
        color.R = (color.R + 1) % 256;
        color.G = (color.G + 2) % 256;
        color.B = (color.B + 3) % 256;

        // Set the background color every frame
        Window.ClearBackground(color);

        // Show the color value on screen
        string text = $"Color({color.R:000}, {color.G:000}, {color.B:000})";
        Text.Color = Color.White;
        Text.Draw(text, 10, 10);
        Text.Draw(text, 10, 12);
        Text.Draw(text, 12, 10);
        Text.Draw(text, 12, 12);
        Text.Color = Color.Black;
        Text.Draw(text, 11, 11);
    }
}
