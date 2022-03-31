using System;
using System.Numerics;

namespace MonoAsteroids
{
    public interface IGameObject
    {
        bool IsDead { get; set; }
        Vector2 position { get; set; }
        float Radius { get; set; }
        Vector2 Speed { get; set; }
        float Rotation { get; set; }

    }
}