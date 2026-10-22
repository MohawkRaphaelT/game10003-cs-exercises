using System;
using System.Numerics;

namespace MohawkGame2D;

public class Balloon
{
    // Variables for balloon information
    public float x;
    public float y;
    public float radius;
    public float ropeLength;
    public Color color;
    public bool isPopped;

    public void Setup()
    {
        // Basically we just randomize everything
        color = Random.Color();
        radius = Random.Integer(30, 40);
        ropeLength = Random.Integer(50, 120);
        x = Random.Float(radius, Window.Width - radius);
        y = Random.Float(radius, Window.Height - radius);
    }

    public void Update()
    {
        // Check to see if mouse is overtop of circle
        if (Input.IsMouseButtonPressed(MouseButton.Left) == true)
        {
            // d for delta. Delta means difference between 2 points.
            float dx = x - Input.GetMouseX();
            float dy = y - Input.GetMouseY();
            // hypoteneuse = square root of (x^2 + y^2)
            float distance = MathF.Sqrt(dx*dx + dy*dy);
            if (distance <= radius)
            {
                isPopped = true;
            }
        }

        if (isPopped)
        {
            // Draw popped lines
            Draw.LineSize = 5;
            Draw.LineColor = Color.Gray;
            // Use a for loop and sine/cosine to draw lines along perimeter of circle
            for (float theta = 0; theta <= MathF.PI; theta += MathF.Tau / 8)
            {
                float x0 = x + MathF.Sin(theta           ) * radius;
                float x1 = x + MathF.Sin(theta + MathF.PI) * radius;
                float y0 = y + MathF.Cos(theta           ) * radius;
                float y1 = y + MathF.Cos(theta + MathF.PI) * radius;
                Draw.Line(x0, y0, x1, y1);
            }
        }
        else
        {
            // Draw balloon
            Draw.LineSize = 1;
            Draw.LineColor = Color.Black;
            Draw.FillColor = color;
            Draw.Line(x, y, x, y + ropeLength);
            Draw.Circle(x, y, radius);
            Draw.Triangle(x, y + radius, x - 10, y + radius + 10, x + 10, y + radius + 10);
        }
    }
}
