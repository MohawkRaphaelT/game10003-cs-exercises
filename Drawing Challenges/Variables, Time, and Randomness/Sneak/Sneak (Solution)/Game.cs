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
    float timeBeforeTurning;
    bool isFacingAway;
    float resetPlayerY = 375;
    float playerY = 375;

    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()
    {
        Window.SetTitle("Sneak");
        Window.SetSize(400, 400);
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        // Clear window
        Window.ClearBackground(240);

        // Decrement time remaining
        timeBeforeTurning -= Time.DeltaTime;
        // 
        if (isFacingAway == false)
        {
            // Draw Mr.Wolf in red
            Draw.SetFillColor(255, 0, 0);
            Draw.Square(175, 25, 50);

            // If we are walking, then we lose. We reset the player and Mr.Wolf.
            if (Input.IsKeyboardKeyDown(KeyboardKey.Space) == true)
            {
                // Reset player position
                playerY = resetPlayerY;
                // Reset Mr.Wolf
                isFacingAway = true;
                timeBeforeTurning = Random.Float(0.7f, 3.0f);
            }

            // Face away if timer runs out
            if (timeBeforeTurning <= 0)
            {
                isFacingAway = true;
                timeBeforeTurning = Random.Float(0.5f, 1.5f);
            }
        }
        else // isFacingAway == true
        {
            // Draw Mr.Wolf color based if close to turning around or not
            if (timeBeforeTurning <= 0.400f)
            {
                // Orange
                Draw.SetFillColor(255, 128, 0);
            }
            else
            {
                // Green
                Draw.SetFillColor(0, 255, 0);
            }
            Draw.Square(175, 25, 50);

            // If not faced, we can walk forward
            if (Input.IsKeyboardKeyDown(KeyboardKey.Space) == true)
            {
                // Player moves at 75 pixels per second
                playerY -= 75 * Time.DeltaTime;
            }

            // Face player if timer runs out
            if (timeBeforeTurning <= 0)
            {
                isFacingAway = false;
                timeBeforeTurning = Random.Float(0.3f, 1f);
            }
        }

        // Draw player
        Draw.SetFillColor(0, 128, 255);
        Draw.Circle(200, playerY, 25);
    }

}
