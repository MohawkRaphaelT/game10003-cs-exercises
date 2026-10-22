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
    // Array of skulls
    Skull[] skulls = new Skull[5];

    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()
    {
        Window.SetTitle("Chattering Skulls");
        Window.SetSize(400, 400);
        // Slow FPS a bit so that chatteing is more noticeable
        Window.TargetFPS = 30;

        // Set these skulls to a fixed position once
        skulls[0] = new Skull();
        skulls[0].x = 100;
        skulls[0].y = 100;

        skulls[1] = new Skull();
        skulls[1].x = 300;
        skulls[1].y = 100;

        skulls[2] = new Skull();
        skulls[2].x = 100;
        skulls[2].y = 300;

        skulls[3] = new Skull();
        skulls[3].x = 300;
        skulls[3].y = 300;

        // This one will use mouse position every frame
        skulls[4] = new Skull();
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        // clear the background to be black
        Window.ClearBackground(Color.Black);

        // Draw 3 skulls
        skulls[4].x = Input.GetMouseX();
        skulls[4].y = Input.GetMouseY();

        // Update all skulls
        for (int i = 0; i < skulls.Length; i++)
        {
            skulls[i].Update();
        }
    }

}
