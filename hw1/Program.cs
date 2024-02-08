

using hw1;

Cache<int> cache=new Cache<int>();
cache.Add(4);
cache.Add(5);
cache.Add(6);
foreach (var item in cache.Get())
{
    System.Console.WriteLine(item);
}
cache.Remove(5);
foreach (var item in cache.Get())
{
    System.Console.WriteLine(item);
}