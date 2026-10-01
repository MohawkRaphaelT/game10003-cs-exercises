// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
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
            Window.SetTitle("Wobbly Lines");
            Window.SetSize(400, 400);
            // Same color as background
            Draw.SetFillColor(240);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Same color as ellipses
            Window.ClearBackground(240);

            Draw.SetLineColor(Random.Integer(160, 190));
            Draw.SetLineSize(Random.Float(15, 20));
            Draw.Ellipse(200, 200, Random.Float(150, 180), Random.Float(150, 180));

            Draw.SetLineColor(Random.Integer(120, 150));
            Draw.SetLineSize(Random.Float(10, 15));
            Draw.Ellipse(200, 200, Random.Float(150, 180), Random.Float(150, 180));

            Draw.SetLineColor(Random.Integer(80, 110));
            Draw.SetLineSize(Random.Float(5, 10));
            Draw.Ellipse(200, 200, Random.Float(150, 180), Random.Float(150, 180));
        }
    }

}
