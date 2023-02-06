namespace ArrayOfMultiples;

public class Class1
{
    public int[] Run(int num, int length)
    {
        var ret = new int[length];

        for (int i = 0; i < length; i++)
        {
            int numberToMultiple = i + 1;
            ret[i] = numberToMultiple * num;
        }

        return ret;
    }
}