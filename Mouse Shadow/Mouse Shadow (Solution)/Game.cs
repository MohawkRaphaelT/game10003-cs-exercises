// CHALLENGE: Update the code so that the shadows are drawn where the mouse
//            was on screen rather than exactly where the mouse is.
// Hint 1: Focus on one shadow. The logic can be applied to all afterwards.
// Hint 2: Consider how you can make the program remember last frame's mouse position.

using System;
using System.Numerics;

namespace Game10003;

public class Game
{
    // Prepare custom colors to use.
    // A single value means intensity (black-and-white).
    Color black = new Color(0);
    Color shadow1 = new Color(70);
    Color shadow2 = new Color(140);
    Color shadow3 = new Color(210);
    // Record last frames' mouse position for shadows
    float shadow1X;
    float shadow2X;
    float shadow3X;
    float shadow1Y;
    float shadow2Y;
    float shadow3Y;

    public void Setup()
    {
        Window.SetTitle("Mouse Shadow");
        Window.SetSize(400, 400);
        // Run a little slower so we have more time to see the shadow
        Window.TargetFPS = 30;
        // Remove outlines
        Draw.LineColor = Color.Clear;
    }

    public void Update()
    {
        // Reset screen
        Window.ClearBackground(Color.OffWhite);

        // Get mouse position
        float mouseX = Input.GetMouseX();
        float mouseY = Input.GetMouseY();

        // Draw shadow 3
        Draw.FillColor = shadow3;
        Draw.Circle(shadow3X, shadow3Y, 16);

        // Draw shadow 2
        Draw.FillColor = shadow2;
        Draw.Circle(shadow2X, shadow2Y, 19);

        // Draw shadow 1
        Draw.FillColor = shadow1;
        Draw.Circle(shadow1X, shadow1Y, 22);

        // Draw mouse
        Draw.FillColor = black;
        Draw.Circle(mouseX, mouseY, 25);

        // Set each position one after another
        // Shadow 3 is now at shadow 2 position
        shadow3X = shadow2X;
        shadow3Y = shadow2Y;
        // Shadow 2 is now at shadow 1 position
        shadow2X = shadow1X;
        shadow2Y = shadow1Y;
        // Shadow 1 is now at mouse position
        shadow1X = mouseX;
        shadow1Y = mouseY;
    }
}
