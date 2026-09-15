// CHALLENGE: Update the code so that the shadows are drawn where the mouse
//            was on screen rather than exactly where the mouse is.
// Hint 1: Focus on one shadow. The logic can be applied to all afterwards.
// Hint 2: Consider how you can make the program remember last frame's mouse position.

// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D;

public class Game
{
    public void Setup()
    {
        Window.SetTitle("Mouse Shadow");
        Window.SetSize(400, 400);
        // Run a little slower so we have more time to see the shadow
        Window.TargetFPS = 30;
        // Remove outlines
        Draw.SetLineSize(0);
    }

    public void Update()
    {
        // Reset screen
        Window.ClearBackground(240);

        // Get mouse position
        float mouseX = Input.GetMouseX();
        float mouseY = Input.GetMouseY();

        // Draw shadow 3
        Draw.SetFillColor(210);
        Draw.Circle(mouseX, mouseY, 16);

        // Draw shadow 2
        Draw.SetFillColor(140);
        Draw.Circle(mouseX, mouseY, 19);

        // Draw shadow 1
        Draw.SetFillColor(70);
        Draw.Circle(mouseX, mouseY, 22);

        // Draw mouse
        Draw.SetFillColor(0);
        Draw.Circle(mouseX, mouseY, 25);
    }
}
