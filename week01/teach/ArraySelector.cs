public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        // We fix the index on the array because the select array has more space than the first and second array, so we need to track a new index to avoid a range Exception on terminal.
        int index1 = 0;
        int index2 = 0;

        // We use for loop to iterate the array sellected, then we verify if l1 and l2 are selected to use into the select array. 
        // we run the complete length of the select array because we need to verify all the elements, 
        // and we use the index1 and index2 to track the position of the l1 and l2 arrays, so we can print the correct element of each array. 
        for (int i = 0; i < select.Length; i++)
        {
            if (select[i] == 1)
            {
                Console.Write(list1[index1] + " ");
                // we use index1 instead of i because we need to track the position of the l1 array, we canot continue with i because is a longer array than the l1 and l2
                index1++;   
            }
            else if (select[i] == 2)
            {
                Console.Write(list2[index2] + " ");
                // same here with index2 we must use it to compare both list and add it into select.
                index2++;   
            }
            
        }

        return [];
    }
}