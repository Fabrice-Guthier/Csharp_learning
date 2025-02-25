﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_POO_Roguelike_test
{
    public abstract class Encounter
    {
        public abstract void Interact(Player player);
    }

    public class Treasure : Encounter
    {
        public int HealthBonus { get; set; }
        public int AttackBonus { get; set; }
        public int SpeedBonus { get; set; }

        public Treasure(int healthBonus, int attackBonus, int speedBonus)
        {
            HealthBonus = healthBonus;
            AttackBonus = attackBonus;
            SpeedBonus = speedBonus;
        }

        public override void Interact(Player player)
        {
            player.Health += HealthBonus;
            player.Attack += AttackBonus;
            player.Speed += SpeedBonus;
            Console.WriteLine("Vous avez trouvé un trésor !");
        }
    }
}
