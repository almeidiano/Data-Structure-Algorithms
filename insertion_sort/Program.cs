using System.Runtime.InteropServices;

class Program
{
    public int[] insertion_sort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int position = i;
            int temp_value = array[i];

            while (position > 0 && array[position - 1] > temp_value)
            {
                array[position] = array[position - 1];
                position = position - 1;
            }

            array[position] = temp_value;
        }

        return array;
    }
    static void Main()
    {
        Program program = new Program();

        int[] group = program.insertion_sort([8, 4, 2, 3]);

        foreach (var i in group)
        {
            Console.WriteLine(i);
        }
    }
}