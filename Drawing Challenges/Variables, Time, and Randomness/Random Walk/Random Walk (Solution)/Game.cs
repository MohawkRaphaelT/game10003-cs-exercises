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
    float x = 200;
    float y = 200;

    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()
    {
        Window.SetTitle("Random Walk");
        Window.SetSize(400, 400);
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        // Update the current position of the circle
        // Here, we multiply by Time.DeltaTime so that
        // we guarantee the circle moves at most 200px
        // per second rather than per frame.
        x += Random.Float(-200, 200) * Time.DeltaTime;
        y += Random.Float(-200, 200) * Time.DeltaTime;

        // Clear window
        Window.ClearBackground(240);

        // Draw circle that will "walk" around the screen.
        Draw.SetLineSize(0);
        Draw.SetFillColor(255, 0, 0);
        Draw.Circle(x, y, 15);
    }
}
