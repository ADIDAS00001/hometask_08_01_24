using System.Numerics;

namespace hw1;

public class Cache<T>
{
    List<T> number = new List<T>();
    public List<T> Get()
    {
        return number;
    }
    public void Add(T num)
    {
        number.Add(num);
    }
    public void Remove(T num)
    {
        number.Remove(num);
    }
    

}

