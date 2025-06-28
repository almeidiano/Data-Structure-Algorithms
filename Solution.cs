class Solution
{
    private bool isSorted(int[] array)
    {
        return array.SequenceEqual(array.OrderBy(x => x));
    }
    public int[] selection_sort(int[] nums)
    {
        bool sorted = false;
        bool swapped = false;
        int lowest_value = 0;

        // indicator used to ignore the first position, 
        // since the lowest value is already in the first position, it's valid to ignore it.
        int index = 0;

        // while isn't sorted, the function will run this loop
        while (!sorted)
        {
            // the same as the index indicator
            lowest_value = index;

            for (int i = index; i < nums.Length; i++)
            {
                // if the next number is greater than the current, swap the positions.
                if (nums[i] < nums[lowest_value])
                {
                    lowest_value = i;
                    swapped = true;
                }
            }

            // After the loop is traveled and a swap is did, swap the values.
            // It's necessary to put the lowest value in the lowest position and change the current index algorithm position.
            if (swapped)
            {
                int temp = nums[index];
                nums[index] = nums[lowest_value];
                nums[lowest_value] = temp;
                index++;
            }

            if (isSorted(nums))
            {
                sorted = true;
            }

        }

        return nums;
    }
    static void Main()
    {
        Solution solucao = new Solution();
        int[] group = solucao.selection_sort([4,2,7,1,3]);

        foreach (var individual in group) {
            Console.WriteLine(individual);
        }
    }
}



