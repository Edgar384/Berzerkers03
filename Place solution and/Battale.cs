using Orc;
using System;
using Units;
using Units.Fishman;
using static System.Console;

#region
List<Unit> group1 = new()
{
    new OrcSoldier(),
    new OrcMage(),
    new WarOrc(),
};

List<Unit> group2 = new()
{
    new FishmanBrute(),
    new FishmanSlinger(),
    new FishmanBrute(),

};
#endregion


Fight(group1, group2);

static void Fight(List<Unit> group1, List<Unit> group2)
{
    var turn = Random.Shared.Next(1, 3);
    while (group1.Count > 0 && group2.Count > 0)
    {
        var place1 = Random.Shared.Next(0, group1.Count);
        var place2 = Random.Shared.Next(0, group2.Count);
        if (turn == 1)
        {
            var p1 = group1[place1];
            var p2 = group2[place2];

            if (p1.HitChance.GetRandom() > p2.DefChance.GetRandom())
            {
                WriteLine($"Notice! P1:{p1} has successfully attacked P2:{p2}");
                p1.Attack(p2);

                if (p2.HP <= 0)
                {
                    if (p1.CarryCapacity < p1.BaseCapacity)
                        p1.CarryCapacity += p2.BaseCapacity;
                    WriteLine($"P2:{p2} has died");
                    WriteLine($"Player 1 had won the battle!");
                    WriteLine($"Player 1 stole resources:{p2.BaseCapacity}");
                    group2.Remove(group2[place2]);

                }
            }
            else
            {
                WriteLine("bolcked");
                p2.Defend(p1);
            }

            turn = 2;
            continue;
        }
        else if (turn == 2)
        {
            var p1 = group2[place2];
            var p2 = group1[place1];

            if (p1.HitChance.GetRandom() > p2.DefChance.GetRandom())
            {

                if (p1.HitChance.GetRandom() > p2.DefChance.GetRandom())
                {
                    WriteLine($"Notice! P1:{p1} has successfully attacked P2:{p2}");
                    p1.Attack(p2);

                    if (p2.HP <= 0)
                    {
                        if (p1.CarryCapacity < p1.BaseCapacity)
                            p1.CarryCapacity += p2.BaseCapacity;
                        WriteLine($"P1:{p2} has died");
                        WriteLine($"Player 2 had won the battle!");
                        WriteLine($"Player 2 stole resources:{p1.BaseCapacity}");
                        group1.Remove(group1[place1]);

                    }
                }
                else
                {
                    WriteLine("bolcked");
                    p2.Defend(p1);
                }

                turn = 1;
                continue;
            }
        }

    }
}



