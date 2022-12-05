using System;
using Units;

namespace Units.Skeleton
{

    class SkeletonSword : Unit
    {
        public SkeletonSword()
        {
            Damage = new Dice(1, 10, 2);
            HP = 40;
            Race = UnitRace.fishman;
            HitChance = new Dice(1, 3, 1);
            DefChance = new Dice(2, 4, 1);
            Weather = UnitWeather.rain;
            CarryCapacity = 30;
            BaseCapacity = 10;
        }
        public override void Attack(Unit defender)
        {
            defender.Defend(this);
        }
        public override void Defend(Unit attacker)
        {
            ApplyDamage(attacker.Damage.GetRandom());
        }
    }

    class skeletonArcher : ArcherUnit
    {
        public skeletonArcher()
        {
            Damage = new Dice(1, 10, 2);
            HP = 40;
            range = 2f;
            Race = UnitRace.fishman;
            HitChance = new Dice(1, 3, 1);
            DefChance = new Dice(2, 4, 1);
            Weather = UnitWeather.rain;
            CarryCapacity = 30;
            BaseCapacity = 10;
        }

        public override void Attack(Unit defender)
        {
            defender.Defend(this);
        }
        public override void Defend(Unit attacker)
        {
            ApplyDamage(attacker.Damage.GetRandom());
        }
    }

    class skeletonKnight : WarriorUnit
    {
        public skeletonKnight()
        {
            Damage = new Dice(1, 10, 2);
            HP = 40;
            shild = 2f;
            Race = UnitRace.fishman;
            HitChance = new Dice(1, 3, 1);
            DefChance = new Dice(2, 4, 1);
            Weather = UnitWeather.rain;
            CarryCapacity = 30;
            BaseCapacity = 10;
        }
        public override void Attack(Unit defender)
        {
            defender.Defend(this);
        }
        public override void Defend(Unit attacker)
        {
            ApplyDamage(attacker.Damage.GetRandom());
        }
    }
    
}