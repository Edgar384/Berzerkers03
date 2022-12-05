
using Units;
#region
namespace Orc
{
    class OrcSoldier : WarriorUnit
    {
        public OrcSoldier()
        {
            this.Damage = new Bag(6);
            HP = 20;
            Race = UnitRace.Orc;
            HitChance = new Bag(3);
            DefChance = new Bag(3);
            Weather = UnitWeather.sun;
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

    class OrcMage : ArcherUnit
    {
        public OrcMage()
        {
            Damage = new Dice(2, 4, 4);
            range = 3f;
            HP = 15;
            Race = UnitRace.Orc;
            HitChance = new Dice(1, 4, 2);
            DefChance = new Dice(1, 4, 2);
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

    class WarOrc : WarriorUnit
    {
       public WarOrc()
        {
            Damage = new Dice(1, 10, 3);
            shild = 3f;
            HP = 30;
            Race = UnitRace.Orc;
            HitChance = new Dice(1, 6, 2);
            DefChance = new Dice(1, 8, 2);
            Weather = UnitWeather.sun;
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
#endregion
