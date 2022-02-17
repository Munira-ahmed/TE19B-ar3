using System;
using System.Collections.Generic;
using System.Numerics;

namespace Labb17
{
    public class classes
    {
           class GameObject
    {
        public bool IsDead { get; set; }
        
        public float Radius { get; set; }
        public float Rotation { get; set; }
        public Vector2 Speed { get; set; }
        public Vector2 Position { get; set; }

        public bool CollidesWith(IGameObject other)
        {

            return false;
        }
    }

    public interface IGameObject
    {
    }

    class Meteor : GameObject
    {
        public MeteorType Type { get; set; }
        public float ExplosionScale { get; set; }

       public void Meter( MeteorType type)
       {
           
       }
       public void Update(GameTime gameTime)
       {
           
       }
       public IEnumerable<Meteor> BreakMeteor(Meteor meteor)
       {
           return null;
       }
    }

    public class GameTime
    {
    }

    public class MeteorType
    {
    }
    }
}