using System;
using Units;

namespace Units.Fishman
{

    class FishmanSword : Unit
    {
        public FishmanSword()
        {
            Damage = new Bag(5);
            HP = 18;
            Race = UnitRace.fishman;
            HitChance = new Bag(3);
            DefChance = new Bag(2);
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

    class FishmanSlinger : ArcherUnit
    {
        public FishmanSlinger()
        {
            Damage = new Dice(2, 2, 3);
            HP = 25;
            range = 2f;
            Race = UnitRace.fishman;
            HitChance = new Dice(2, 2, 2);
            DefChance = new Dice(1, 2, 2);
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

    class FishmanBrute : WarriorUnit
    {
        public FishmanBrute()
        {
            Damage = new Dice(1,10, 2);
            HP = 40;
            shild = 3f;
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
