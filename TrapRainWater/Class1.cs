namespace TrapRainWater;
public class Class1
{
    public int Trap(int[] height)
    {
        int result = 0;
        int max = height[0];
        List<int> numbHolder = new List<int>();
        for (int i = 1; i < height.Length; i++)
        {
            if (height[i] > max)
            {
                max = height[i];
                foreach (int num in numbHolder)
                {
                    Console.WriteLine($"Numbs being added: {num}, current index: {i}");
                    result += num;
                }
                numbHolder.Clear();
            }
            else if (height[i] < max)
            {
                numbHolder.Add(max - height[i]);
            }
            else
            {
                continue;
            }
        }
        return result;
    }
}
