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
        // Set up window
        Window.SetTitle("Lady Bacon");
        Window.SetSize(400, 400);
        // Remove outlines
        Draw.SetLineSize(0);
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        // Colors
        // Light Pink = (242, 165, 172)
        // Dark Pink = (224, 108, 118)
        // Brown = (59, 48, 45)

        // A
        // Reset background
        Window.ClearBackground(240);

        // E
        // Ground
        Draw.SetFillColor(195);
        Draw.Ellipse(200, 290, 260, 40);

        // B
        // Body
        Draw.SetFillColor(242, 165, 172);
        Draw.Capsule(140, 192, 250, 187, 75);

        // F
        // Ears
        Draw.SetFillColor(224, 108, 118);
        Draw.Triangle(50, 120, 110, 110, 70, 155);
        Draw.Triangle(135, 100, 190, 110, 140, 150);

        // G
        // Tail
        Draw.SetFillColor(242, 165, 172);
        Draw.Triangle(360, 130, 335, 170, 300, 150);

        // D
        // Legs
        Draw.SetFillColor(242, 165, 172);
        Draw.Quad(120, 250, 150, 250, 145, 290, 125, 290);
        Draw.Quad(215, 240, 255, 240, 245, 275, 225, 275);
        Draw.Quad(170, 250, 210, 250, 203, 300, 177, 300);
        Draw.Quad(260, 240, 300, 240, 293, 290, 267, 290);

        // C
        // Hooves
        Draw.SetFillColor(59, 48, 45);
        Draw.Rectangle(122, 278, 25, 12);
        Draw.Rectangle(223, 273, 25, 11);
        Draw.Rectangle(175, 288, 30, 12);
        Draw.Rectangle(265, 278, 30, 12);

        // I
        // Mouth
        Draw.SetFillColor(224, 108, 118);
        Draw.Ellipse(115, 225, 45, 30);
        Draw.SetFillColor(242, 165, 172);
        Draw.Rectangle(90, 210, 50, 15);

        // J
        // Eyes
        Draw.SetFillColor(59, 48, 45);
        Draw.Circle(80, 170, 12);
        Draw.Circle(150, 170, 12);

        // H
        // Nose
        Draw.SetFillColor(224, 108, 118);
        Draw.Ellipse(105, 200, 50, 40);
        Draw.SetFillColor(59, 48, 45);
        Draw.Ellipse(97, 200, 10, 20);
        Draw.Ellipse(113, 200, 10, 20);
    }
}
