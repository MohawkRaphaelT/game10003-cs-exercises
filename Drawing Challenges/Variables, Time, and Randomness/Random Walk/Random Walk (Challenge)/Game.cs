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
        // Draw circle that will "walk" around the screen.
        Draw.SetLineSize(0);
        Draw.SetFillColor(255, 0, 0);
        Draw.Circle(200, 200, 15);

        // HINT: you will need to use variables to have the program
        // remember where the circle was at the end of the last frame.
        // Further, you will need to use the Random class (check API).
        // You might make use of the Time class, too (check API).
    }
}
