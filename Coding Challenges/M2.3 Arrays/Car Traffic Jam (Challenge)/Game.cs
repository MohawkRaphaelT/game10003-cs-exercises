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
    // One car variable per car on screen
    Car car1 = new Car();
    Car car2 = new Car();
    Car car3 = new Car();
    Car car4 = new Car();
    Car car5 = new Car();

    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()
    {
        Window.SetTitle("Car Traffic Jam");
        Window.SetSize(400, 400);

        // Set up each car
        car1.Setup();
        car2.Setup();
        car3.Setup();
        car4.Setup();
        car5.Setup();
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        Window.ClearBackground(Color.OffWhite);

        // Update each car
        car1.Update();
        car2.Update();
        car3.Update();
        car4.Update();
        car5.Update();
    }
}
