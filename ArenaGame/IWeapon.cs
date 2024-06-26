﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArenaGame.GameEngine;

namespace ArenaGame
{
    public interface IWeapon
    {
        string Name { get; }
        double AttackDamage { get; }
        double BlockingPower { get; }
        SpecialAbilities SpecialAbilities { get; }

        void CalculateDamages(Hero attacker, Hero defender, WeaponEffectNotify weaponEffect);

    }
}
