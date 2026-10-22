using System;
using System.Numerics;

namespace MohawkGame2D;

public class RainDrop
{
    public float x;
    public float y;
    public float speedX;
    public float speedY;

    public void Setup()
    {
        // Random velocity downwards
        speedX = Random.Float(-30, 30);
        speedY = Random.Float(600, 660);

        // Random position on screen (and slightly outside bounds of X)
        x = Random.Integer(-100, 500);
        y = Random.Integer(Window.Height);
    }

    public void Update()
    {
        // Compute movement
        float displacementX = speedX * Time.DeltaTime;
        float displacementY = speedY * Time.DeltaTime;
        // Draw rain movement
        Draw.LineSize = 1;
        Draw.LineColor = Color.White;
        Draw.Line(x, y, x + displacementX, y + displacementY);
        // Move rain for next frame
        x += displacementX;
        y += displacementY;

        // if below bottom screen
        if (y > Window.Height)
        {
            // New random X position
            x = Random.Integer(-100, 500);
            // Y coordinate is just above screen
            y = -speedY * Time.DeltaTime;
        }
    }
}
