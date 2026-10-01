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
    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()
    {
        Window.SetTitle("Spider Web");
        Window.SetSize(400, 400);
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        Window.ClearBackground(240);
        Draw.SetLineSize(2);

        // Draw concentric circles
        Draw.SetFillColor(240);
        for (int i = 400; i > 0; i -= 40)
        {
            Draw.Circle(200, 200, i);
        }

        // Draw lines
        for (int i = 0; i <= 400; i += 80)
        {
            float a = i;
            float b = Window.Height - i;
            Draw.Line(0, a, 400, b);
            Draw.Line(a, 0, b, 400);
        }
    }
}
