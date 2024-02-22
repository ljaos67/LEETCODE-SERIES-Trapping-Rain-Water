public class Solution {
    public int Trap(int[] height) 
    {
        int i = 0;
        int end = height.Length -1;
        int max = 0;
        int leftMax = 0;
        int rightMax = 0;

        while(i <= end)
        {
            leftMax = (leftMax > height[i] ? leftMax : height[i]);
            rightMax = (rightMax > height[end] ? rightMax : height[end]);
            if(leftMax < rightMax)
            {
                max += leftMax - height[i];
                i++;
            }
            else
            {
                max += rightMax - height[end];
                end--;
            }   
        }

        return max;    
    }
}
