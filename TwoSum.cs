public class TwoSum
{
    public int[] FindTwoSumResult(int[] nums, int target)
    {
        // int array has 2 elements
        int[] result = new int[2];
        //nums = [11,2,15,7,1,6,2,4,9,3,5,8,10]
        //         i
        //                                  j
        //target = 9
        //return [?,?];

        result.add(1);

        // nums[i] i=0가 하나씩 증가하는 for문을 돌린다.
        for (int i = 0; i < nums.Length; i++)
        {
            // nums[j] j = (i + 1)++ for문을 돌린다.
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                //nums[j] + nums[i] == 9 인지 if문으로 확인한다.
                if (nums[i] + nums[j] == target)
                { //target = 9
                    //합이 9가 맞으면 인덱스[i,j]리턴한다.
                    return new int[] { i, j };
                }
            }
        }
        // 합이 9인게 없으면 빈 어레이를 리턴한다. 
        return result;
    }
}