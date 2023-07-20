namespace TrapRainWater;
public class Class1
{
    public int Trap(int[] height)
    {
        int result = 0;
        int left = 0;
        int right = height.Length - 1;
        int leftMax = 0;
        int rightMax = 0;
        while (left < right)
        {
            leftMax = Math.Max(leftMax, height[left]);
            rightMax = Math.Max(rightMax, height[right]);
            if (leftMax < rightMax) 
            {
                result += leftMax - height[left];
                left++;
            } else
            {
                result += rightMax - height[right];
                right--;
            }
        }
        return result;
    }
}
