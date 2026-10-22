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
        Color skyColor = new Color("#1D2B53");
        Color skyColorAlpha = new Color("#1D2B53C0");
        RainDrop[] rainDrops = new RainDrop[1000];

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Rain");
            Window.SetSize(400, 400);
            Window.ClearBackground(skyColor);

            for (int i = 0; i < rainDrops.Length; i++)
            {
                rainDrops[i] = new RainDrop();
                rainDrops[i].Setup();
            }
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(skyColorAlpha);

            for (int i = 0; i < rainDrops.Length; i++)
            {
                rainDrops[i].Update();
            }
        }
    }

}
