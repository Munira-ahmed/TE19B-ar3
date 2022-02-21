using System;

namespace Labb18
{
    
        class Creature
        {
            public int Health { get; set; }
            public int Shield { get; set; }
            public string Name { get; set; }

            public Creature(string name)
            {
                Name = name;
            }

            public string GetInfo()
            {
                string info = $"Name : {Name} \n Health : {Health} \n Shield : {Shield}";
                return info;
            }
        }

        class Knight : Creature
        {
            private string Weapon { get; set; }

            public Knight(string n, string weapon) : base(n)
            {
                Weapon = weapon;
            }
            public void Attack()
            {
                Console.WriteLine($"Knight {Name} attacks with {Weapon}");
            }
        }

        class Dragon :Creature
        {
            private string Color { get; set; }
            public Dragon(string n, string color) : base(n)
            {
                Color = color;
            }
            public void Attack()
            {
                Console.WriteLine($"{Color} dragon {Name} attacks with fire");
            }
        }
    }
