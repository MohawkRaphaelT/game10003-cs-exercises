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
    int r;
    int g;
    int b;

    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()
    {
        Window.SetTitle("Random Color");
        Window.SetSize(256, 256);
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        // If mouse PRESSED, not down, otherwise this runs each frame when
        if (Input.IsMouseButtonPressed(MouseButton.Left))
        {
            // Set variables for color components so program remembers
            r = Random.Integer(0, 256);
            g = Random.Integer(0, 256);
            b = Random.Integer(0, 256);
        }

        // Use those color components to clear the window
        Window.ClearBackground(r, g, b);
    }
}
