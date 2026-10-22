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
        Window.SetTitle("Chattering Skulls");
        Window.SetSize(400, 400);
        // Slow FPS a bit so that chatteing is more noticeable
        Window.TargetFPS = 30;
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        // clear the background to be black
        Window.ClearBackground(Color.Black);

        // Draw 3 skulls
        DrawSkull(Input.GetMouseX(), Input.GetMouseY());
        DrawSkull(100, 100);
        DrawSkull(300, 300);
    }

    public void DrawSkull(float x, float y)
    {
        // Get random int for chattering jitter
        int random1 = Random.Integer(-1, 2);
        int random2 = Random.Integer(-1, 2);
        int random3 = Random.Integer(-1, 2);

        Draw.LineSize = 0;
        // Skull bone
        Draw.FillColor = new Color(128);
        Draw.Circle(x, y, 45);
        Draw.Capsule(x - 24, y, x - 24, y + 50 + random1, 10);
        Draw.Capsule(x     , y, x     , y + 50 + random2, 10);
        Draw.Capsule(x + 24, y, x + 24, y + 50 + random3, 10);
        // Eyes
        Draw.FillColor = Color.Black;
        Draw.Circle(x - 16 + random1, y, 18);
        Draw.Circle(x + 16 + random2, y, 18);
        // Pupils
        Draw.FillColor = Color.Yellow;
        Draw.Circle(x - 16 + random3, y, 3);
        Draw.Circle(x + 16 + random1, y, 3);
    }
}
