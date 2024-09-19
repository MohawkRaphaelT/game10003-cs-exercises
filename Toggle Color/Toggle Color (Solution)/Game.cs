// CHALLENGE: Toggle the square's color between two colors (eg. red and green)
//            when the player either hits spacebar or does a left mouse click.

using System;
using System.Numerics;

namespace Game10003;

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
        Window.ClearBackground(Color.OffWhite);

        // Check for inputs
        bool hasPressedSpacebar = Input.IsKeyboardKeyPressed(KeyboardInput.Space);
        bool hasPressedMouseLeft = Input.IsMouseButtonPressed(MouseInput.Left);

        // Check for toggle (A OR B)
        if (hasPressedSpacebar || hasPressedMouseLeft)
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
            Draw.FillColor = Color.Green;
        }
        else // isActive is false
        {
            Draw.FillColor = Color.Red;
        }

        //Draw square using above color
        Draw.Square(100, 100, 200);
    }
}
