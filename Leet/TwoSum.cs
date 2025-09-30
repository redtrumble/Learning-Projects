public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //Learning C# Using Leet code
        for(int i=0; i <nums.Count();i++){
            for(int j = 0; i < nums.Count() && i != j; j++){
                if(nums[i] + nums[j] == target){
                    return [i,j];
                }
            }
        }
        return [-1,-1]; 
        /*
        int i = 0;
        int j = 0;
        int k = 0;
        while(k != target){
            // catch correct answer
            if ((nums[i] + nums[j] == target) && (i != j)){
                k = target;
                return[i,j];
            }
            //when j reaches end of array start moving i
            else if(j == nums.Count() - 1){
                i++;
                j= i+1;
            }
            // if not right increment j
            else{
                j++;
            }
            //Console.WriteLine("{0}{1}",i,j);
        }
        return [-1,-1];
        */

    }
}

/*
Fastest Solution on Leet:

csharp
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();

        for(var i=0; i<nums.Length; i++)
        {
            var complement = target - nums[i];
            if (!dict.ContainsKey(complement))
                dict[nums[i]]=i;
            else
                return new int[] {dict[complement], i};
        }
        return new int[0];
    }
}
*/