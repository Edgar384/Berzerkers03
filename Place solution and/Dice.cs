
struct Dice : IRandomProvider
{
    uint Scalaer;
    uint BaseDie;
    int Modifer;

    public int GetRandom() { return Roll(); }
        
    public Dice(uint _scalar, uint _baseDie,int _modifer)
    {
        this.Scalaer = _scalar;
        this.BaseDie =_baseDie;
        this.Modifer = _modifer;
    }

    public  int Roll()
    {
        var result = 0;
        for (int i = 0; i<Scalaer; i++)
        {
            result += Random.Shared.Next(1, (int)BaseDie + 1);

            result += Modifer;    
        }
        return result;
    }

    public override string ToString()
    {
        return $"S:{Scalaer},d:{BaseDie},M:{Modifer}";
    }
    public override bool Equals(object? obj)
    {
      Dice d = (Dice)obj;
        return d.Scalaer == Scalaer && BaseDie == d.BaseDie && Modifer == d.Modifer; 
           
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

}

struct Bag : IRandomProvider
{
    List<int> bag = new();
    List<int> bagCopy = new();
    int num = 0;
    public Bag(int num)
    {
        for(int i = 0; i < num; i++)
        {
            bag.Add(i);
        }
    }
    public int GetRandom()
    {
        if(bag.Count > 1)
        {
            var num1 = Random.Shared.Next(0, bag.Count);
            num = bag[num1];
            bagCopy.Add(bag[num1]);
            bag.Remove(bag[num1]);
        }
        else if (bagCopy.Count == 1)
        {
            num = bag[0];
            bagCopy.Add(bag[0]);
            bag.Remove(bag[0]);

            bag = bagCopy;
            bagCopy.Clear();
        }
        return num;
    }
}
    
public interface IRandomProvider
    {
     public int GetRandom();
    }