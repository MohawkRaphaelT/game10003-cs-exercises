// CHALLENGE: Toggle the square's color between two colors (eg. red and green)
//            when the player either hits spacebar or does a left mouse click.

// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D;

public class Game
{
    // Remember toggle state
    bool isActive = false;

    public void Setup()
    {
        Window.SetTitle("Toggle Color");
        Window.SetSize(400, 400);
    }

    public void Update()
    {
        // Reset screen
        Window.ClearBackground(240);

        // Check for inputs
        bool hasPressedSpacebar = Input.IsKeyboardKeyPressed(KeyboardKey.Space);
        bool hasPressedMouseLeft = Input.IsMouseButtonPressed(MouseButton.Left);

        // Check for toggle (A OR B)
        if (hasPressedSpacebar == true || hasPressedMouseLeft == true)
        {
            // Use the ! NOT operator to flip a boolean back and forth
            // !false == true, and !true == false.
            isActive = !isActive;

            // You could also do this. They're the same, but above is very brief.

            //if (isActive == true)
            //{
            //    isActive = false;
            //}
            //else if (isActive == false)
            //{
            //    isActive = true;
            //}
        }

        // Set fill color
        if (isActive == true)
        {
            // Green
            Draw.SetFillColor(0, 255, 0);
        }
        else // isActive is false
        {
            // Red
            Draw.SetFillColor(255, 0, 0);
        }

        //Draw square using above color
        Draw.Square(100, 100, 200);
    }
}
