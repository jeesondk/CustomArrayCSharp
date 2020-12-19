using System;
namespace CustomCollection
{
    public class ExtendedIntegerArray
    {

        private int[] sum;
        private int[] values;

        public ExtendedIntegerArray(int size)
        {
            if (size < 1)
                throw new ArgumentOutOfRangeException("Array size must be greater than 1");

            sum = new int[size];
            values = new int[size];
        }

        public int this[int index] { get => values[index]; set => SetValue(value, index); }

        public int Length => values.Length;

        public int SumOf(int position1, int position2) => Math.Abs(sum[position2] - sum[position1]);


        private void SetValue(int value, int index)
        {
            values.SetValue(value, index);
            if (index > 0)
                sum[index] = value + sum[index - 1];
            else
                sum[index] = value;
        }
    }
}
