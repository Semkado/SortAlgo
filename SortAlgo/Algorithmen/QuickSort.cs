namespace SortAlgo.Algorithmen
{
    class QuickSort : Sort
    {
        int z = 0;

        public void sort(int[] x, int links, int rechts, Form1 f1)
        {
            int[] temparray = new int[x.Length];

            System.Array.Copy(x, temparray, x.Length);
            if (links < rechts)
            {
                int i = partition(x, links, rechts, f1);
                sort(x, links, i - 1, f1);
                sort(x, i + 1, rechts, f1);
            }

            z = ColorNumbers(x, temparray, z, f1);
        }
        public static int partition(int[] x, int links, int rechts, Form1 f1)
        {
            int pivot, i, j, help;
            pivot = x[rechts];
            i = links;
            j = rechts - 1;
            while(i <=j)
            {
                if (x[i] > pivot)
                {
                    //tausche x[i] und x[j]
                    help = x[j];
                    x[i] = x[j];
                    x[j] = help;
                    j--;
                }
                else
                {
                    i++;
                }
            }
            //tausche x[i] und x[rechts]
            help = x[i];
            x[i] = x[rechts];
            x[rechts] = help;
            return i;
        }
    }
}