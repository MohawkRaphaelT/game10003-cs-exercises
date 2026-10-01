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
    float x;
    float y;
    float radius = 35;

    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()
    {
        Window.SetTitle("Random Circle");
        Window.SetSize(400, 400);

        // Compute screen center coordinate
        x = Window.Width / 2;
        y = Window.Height / 2;
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        Window.ClearBackground(240);

        // Check for either mouse or keyboard presses
        if (Input.IsKeyboardKeyPressed(KeyboardKey.Space) == true ||
            Input.IsMouseButtonPressed(MouseButton.Left)  == true)
        {
            // Pcik a random radius
            radius = Random.Float(10, 150);
            // Make sure circle is not too close to screen edge
            x = Random.Float(radius, Window.Width - radius);
            y = Random.Float(radius, Window.Height - radius);
        }

        // Draw circle
        Draw.SetFillColor(0, 128, 255);
        Draw.Circle(x, y, radius);
    }
}
