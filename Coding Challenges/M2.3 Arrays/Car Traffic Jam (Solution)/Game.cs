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
    // One array of all cars, count of 50
    Car[] cars = new Car[50];


    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()
    {
        Window.SetTitle("Car Traffic Jam");
        Window.SetSize(400, 400);

        // Set up each car in array using loop
        for (int i = 0; i < cars.Length; i++)
        {
            // Instantiate car so it is not null
            cars[i] = new Car();
            // Set up car
            cars[i].Setup();
        }
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        Window.ClearBackground(Color.OffWhite);

        // Update each car
        for (int i = 0; i < cars.Length; i++)
        {
            cars[i].Update();
        }
    }
}
