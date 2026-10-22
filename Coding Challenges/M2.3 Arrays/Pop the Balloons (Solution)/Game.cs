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
    // One array for all balloons
    Balloon[] balloons = new Balloon[15];

    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()
    {
        Window.SetTitle("Pop the Balloons");
        Window.SetSize(400, 400);

        // Set up each balloon in array with loop
        for (int i = 0; i < balloons.Length; i++)
        {
            balloons[i] = new Balloon();
            balloons[i].Setup();
        }
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        Window.ClearBackground(Color.OffWhite);

        // Update each balloon
        for (int i = 0; i < balloons.Length; i++)
        {
            balloons[i].Update();
        }
    }
}
