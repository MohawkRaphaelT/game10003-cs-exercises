using System;
using System.Numerics;

namespace MohawkGame2D;

public class Car
{
    // Variables for car information
    public Color color = Color.Red;
    public float x;
    public float y;
    public float speedX;

    public void Setup()
    {
        // Basically we just randomize everything
        color = Random.Color();
        x = Random.Integer(Window.Width);
        y = Random.Integer(Window.Height);
        speedX = Random.Integer(80, 240);
    }

    public void Update()
    {
        // Update position
        x += speedX * Time.DeltaTime;

        // Wrap car position
        if (x > Window.Width)
        {
            // Off-screen on left
            x = -60;
            // Random vertical position
            y = Random.Integer(Window.Height);
        }

        Draw.LineSize = 0;
        // Car body
        Draw.FillColor = color;
        Draw.Rectangle(x, y, 60, 20);
        Draw.Rectangle(x + 10, y - 15, 40, 15);
        // Car wheels
        Draw.FillColor = Color.Black;
        Draw.Circle(x + 10, y + 20, 10);
        Draw.Circle(x + 50, y + 20, 10);
    }
}
