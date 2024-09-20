// CHALLENGE: draw one of the Space Invader sprites using regular draw calls.

using System;
using System.Numerics;

namespace Game10003
{
    public class Game
    {
        public void Setup()
        {
            Window.SetTitle("Draw Character Function");
            Window.SetSize(400, 400);
        }

        public void Update()
        {
            // Clear background
            Window.ClearBackground(Color.Black);

            // Reuse draw function, giving each call different coordinates to draw at.
            DrawSpaceInvaderCrab(20, 40);
            DrawSpaceInvaderCrab(260, 100);
            DrawSpaceInvaderCrab(200, 300);
            DrawSpaceInvaderCrab(40, 220);
        }

        // Define the function. It takes in an X and Y coordinate to position the drawing.
        // https://web.archive.org/web/20160403080807/http://trendy.nikkeibp.co.jp/article/special/20080318/1008218/?SS=expand-digital&FD=-1032936769
        public void DrawSpaceInvaderCrab(float x, float y)
        {
            // Set drawing properties
            Draw.LineColor = Color.Clear;
            Draw.FillColor = Color.Yellow;

            // Sprite "pixel" size
            int p = 10;

            // How this drawing code works:
            // x+ OR y+: use input x/y screen coordinate as the origin for drawing.
            // p * n   : offset the square or rect p pixels horizontally or vertically
            //           for each block in the sprite. Think of n (the number) as the
            //           row or column in the sprite. First row/col is 0, or no offset.

            // row 0
            Draw.Square(x + p * 2, y + p * 0, p);
            Draw.Square(x + p * 8, y + p * 0, p);
            // row 1
            Draw.Square(x + p * 3, y + p * 1, p);
            Draw.Square(x + p * 7, y + p * 1, p);
            // row 2
            Draw.Rectangle(x + p * 2, y + p * 2, p * 7, p);
            // row 3
            Draw.Rectangle(x + p * 1, y + p * 3, p * 2, p);
            Draw.Rectangle(x + p * 4, y + p * 3, p * 3, p);
            Draw.Rectangle(x + p * 8, y + p * 3, p * 2, p);
            // row 4
            Draw.Rectangle(x + p * 0, y + p * 4, p * 11, p);
            // row 5
            Draw.Square(x + p *  0, y + p * 5, p);
            Draw.Rectangle(x + p * 2, y + p * 5, p * 7, p);
            Draw.Square(x + p * 10, y + p * 5, p);
            // row 6
            Draw.Square(x + p *  0, y + p * 6, p);
            Draw.Square(x + p *  2, y + p * 6, p);
            Draw.Square(x + p *  8, y + p * 6, p);
            Draw.Square(x + p * 10, y + p * 6, p);
            // row 7
            Draw.Rectangle(x + p * 3, y + p * 7, p * 2, p);
            Draw.Rectangle(x + p * 6, y + p * 7, p * 2, p);
        }
    }
}
