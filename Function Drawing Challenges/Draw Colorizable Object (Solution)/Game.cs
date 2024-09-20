// CHALLENGE: create a function that draws something to the screen. Give the function a
//            parameter for color, and use that color when drawing the object. Call that
//            function multiple times using different colors to draw the same object but
//            with different colors.

using System;
using System.Numerics;

namespace Game10003
{
    public class Game
    {
        // Ghost colors
        // Ref 1: https://www.schemecolor.com/pac-man-ghosts-color-palette.php
        // Ref 2: https://www.schemecolor.com/pac-man-game-colors.php
        Color inkyRed = new Color(255, 0, 0);
        Color pinkyPink = new Color(255, 184, 255);
        Color blinkyCyan = new Color(0, 255, 255);
        Color clydeOrange = new Color(255, 184, 82);
        Color eyeWhite = new Color(255);
        Color eyeIris = new Color(33, 33, 222);

        public void Setup()
        {
            Window.SetTitle("Draw Colorizable Object");
            Window.SetSize(400, 400);
        }

        public void Update()
        {
            // Clear screen
            Window.ClearBackground(Color.Black);

            // Inky
            DrawPacmanGhost( 30,  30, inkyRed);
            // Pinky
            DrawPacmanGhost(220,  30, pinkyPink);
            // Blinky
            DrawPacmanGhost( 30, 220, blinkyCyan);
            // Clyde
            DrawPacmanGhost(220, 220, clydeOrange);
        }

        // Define the function. It takes in an X and Y coordinate to position the drawing.
        public void DrawPacmanGhost(float x, float y, Color ghostColor)
        {
            // Sprite "pixel" size
            int p = 10;

            // How this drawing code works:
            // x+ OR y+: use input x/y screen coordinate as the origin for drawing.
            // p * n   : offset the square or rect p pixels horizontally or vertically
            //           for each block in the sprite. Think of n (the number) as the
            //           row or column in the sprite. First row/col is 0, or no offset.

            // No shape outline
            Draw.LineColor = Color.Clear;

            // Ghost body
            Draw.FillColor = ghostColor;
            Draw.Rectangle(x + p * 5, y + p * 0, p * 4, p); // row 0
            Draw.Rectangle(x + p * 3, y + p * 1, p * 8, p); // row 1
            Draw.Rectangle(x + p * 2, y + p * 2, p * 10, p); // row 2
            Draw.Rectangle(x + p * 1, y + p * 3, p * 12, p * 3); // row 3
            Draw.Rectangle(x + p * 0, y + p * 6, p * 14, p * 6); // row 6
            // row 12
            Draw.Rectangle(x + p * 0, y + p * 12, p * 4, p);
            Draw.Rectangle(x + p * 5, y + p * 12, p * 4, p);
            Draw.Rectangle(x + p * 10, y + p * 12, p * 4, p);
            // row 13
            Draw.Rectangle(x + p * 1, y + p * 13, p * 2, p);
            Draw.Rectangle(x + p * 6, y + p * 13, p * 2, p);
            Draw.Rectangle(x + p * 11, y + p * 13, p * 2, p);

            // Eye whites
            Draw.FillColor = eyeWhite;
            // left eyes
            Draw.Rectangle(x + p * 2, y + p * 3, p * 2, p * 5);
            Draw.Rectangle(x + p * 1, y + p * 4, p * 4, p * 3);
            // right eye
            Draw.Rectangle(x + p * 8, y + p * 3, p * 2, p * 5);
            Draw.Rectangle(x + p * 7, y + p * 4, p * 4, p * 3);

            // Eye iris
            Draw.FillColor = eyeIris;
            Draw.Square(x + p * 1, y + p * 5, p * 2);
            Draw.Square(x + p * 7, y + p * 5, p * 2);
        }
    }
}
