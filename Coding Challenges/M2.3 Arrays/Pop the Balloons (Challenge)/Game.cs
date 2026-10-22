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
    // One balloon variable per car on screen
    Balloon balloon1 = new Balloon();
    Balloon balloon2 = new Balloon();
    Balloon balloon3 = new Balloon();
    Balloon balloon4 = new Balloon();
    Balloon balloon5 = new Balloon();

    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()
    {
        Window.SetTitle("Pop the Balloons");
        Window.SetSize(400, 400);

        // Set up each balloon
        balloon1.Setup();
        balloon2.Setup();
        balloon3.Setup();
        balloon4.Setup();
        balloon5.Setup();
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        Window.ClearBackground(Color.OffWhite);

        // Update each balloon
        balloon1.Update();
        balloon2.Update();
        balloon3.Update();
        balloon4.Update();
        balloon5.Update();
    }
}
