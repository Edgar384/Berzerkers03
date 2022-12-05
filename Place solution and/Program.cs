using System;
#region
namespace Units
{

    abstract class Unit 
    {
        public virtual UnitRace Race { get; set; }
        public virtual UnitWeather Weather { get; set; }
        public virtual IRandomProvider Damage { get; protected set; }
        public virtual float HP { get; protected set; }

        public virtual int CarryCapacity { get;  set; }
        public virtual int BaseCapacity { get; protected set; }

        public virtual IRandomProvider HitChance { get; protected set; }
        public virtual IRandomProvider DefChance { get; protected set; }

        public virtual void Attack(Unit defender)
        {
            
            defender.ApplyDamage(Damage.GetRandom());
        }


        public virtual void Defend(Unit attacker)
        {
            attacker.ApplyDamage(Damage.GetRandom());
        }


        protected void ApplyDamage(float Damage)
        {
            HP -= Damage;
  
        }

        public enum UnitRace { fishman, Orc, skeleton }

        public enum UnitWeather { rain, sun }

    }

    abstract class ArcherUnit : Unit
    {

        public virtual float range { get; protected set; }

        public override void Attack(Unit defender)
        {
            base.Attack(defender);
        }
        public override void Defend(Unit attacker)
        {
            ApplyDamage((float)(attacker.Damage.GetRandom() * range));
        }

        public enum ProjectileType { cannonball, arrow, fireball }


    }

    abstract class WarriorUnit : Unit
    {
        public virtual float shild { get; protected set; }

        public override void Attack(Unit defender)
        {
            base.Attack(defender);

        }
        public override void Defend(Unit attacker)
        {
            ApplyDamage(attacker.Damage.GetRandom() / shild);
        }


    }
}
#endregion