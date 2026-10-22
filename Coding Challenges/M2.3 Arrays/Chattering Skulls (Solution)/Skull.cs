using System;
using System.Numerics;

namespace MohawkGame2D;

public class Skull
{
    public float x;
    public float y;

    public void Update()
    {
        // Get random int for chattering jitter
        int random1 = Random.Integer(-1, 2);
        int random2 = Random.Integer(-1, 2);
        int random3 = Random.Integer(-1, 2);

        Draw.LineSize = 0;
        // Skull bone
        Draw.FillColor = new Color(128);
        Draw.Circle(x, y, 45);
        Draw.Capsule(x - 24, y, x - 24, y + 50 + random1, 10);
        Draw.Capsule(x, y, x, y + 50 + random2, 10);
        Draw.Capsule(x + 24, y, x + 24, y + 50 + random3, 10);
        // Eyes
        Draw.FillColor = Color.Black;
        Draw.Circle(x - 16 + random1, y, 18);
        Draw.Circle(x + 16 + random2, y, 18);
        // Pupils
        Draw.FillColor = Color.Yellow;
        Draw.Circle(x - 16 + random3, y, 3);
        Draw.Circle(x + 16 + random1, y, 3);
    }
}
