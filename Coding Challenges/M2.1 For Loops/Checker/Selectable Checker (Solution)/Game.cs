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
        Window.SetTitle("Selectable Checkerboard Pattern");
        Window.SetSize(400, 400);
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        // Prepare for drawing
        Window.ClearBackground(Color.OffWhite);

        // Compute cell width and height
        int width = Window.Height / 8;
        int height = Window.Height / 8;

        // Iterate over rows
        for (int y = 0; y < 8; y++)
        {
            // Compute y coordinate of cells in this row
            int yCoordinate = y * height;

            // Iterate over columns
            for (int x = 0; x < 8; x++)
            {
                // Compute  x coordinate of cells in this column
                int xCoordinate = x * width;

                // Collision detection
                int mouseX = Input.GetMouseX();
                int mouseY = Input.GetMouseY();
                bool isInsideLeft   = mouseX >= xCoordinate;
                bool isInsideRight  = mouseX <= xCoordinate + width;
                bool isBelowTop    = mouseY >= yCoordinate;
                bool isAboveBottom = mouseY <= yCoordinate + height;
                bool isMouseOvertop = isInsideLeft && isInsideRight && isBelowTop && isAboveBottom;
                if (isMouseOvertop)
                {
                    bool isRed = (x + y) % 2 == 0;
                    if (isRed)
                        Draw.FillColor = Color.Red;
                    else
                        Draw.FillColor = new Color(255, 128, 128);
                    Draw.Rectangle(xCoordinate, yCoordinate, width, height);
                }
                else
                {
                    bool isBlack = (x + y) % 2 == 0;
                    if (isBlack)
                        Draw.FillColor = Color.Black;
                    else
                        Draw.FillColor = Color.White;
                    // Finally draw the rectangle
                    Draw.Rectangle(xCoordinate, yCoordinate, width, height);
                }

                // Sum x/y coordinate, take remainder of that divided by 2
                // If 0, draw white, if 1, draw black
                // This makes sense if you work out each values by hand for
                // a small grid of eg. 4x4!
                //bool isXXX = (x + y) % 2 == 0;
            }
        }
    }
}
