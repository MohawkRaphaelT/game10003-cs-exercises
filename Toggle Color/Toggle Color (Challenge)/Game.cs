// CHALLENGE: Toggle the square's color between two colors (eg. red and green)
//            when the player either hits spacebar or does a left mouse click.

using System;
using System.Numerics;

namespace Game10003;

public class Game
{
    public void Setup()
    {
        Window.SetTitle("Toggle Color");
        Window.SetSize(400, 400);
    }

    public void Update()
    {
        // Reset screen
        Window.ClearBackground(Color.OffWhite);

        // Set fill color
        Draw.FillColor = Color.Red;

        //Draw square using above color
        Draw.Square(100, 100, 200);
    }
}
