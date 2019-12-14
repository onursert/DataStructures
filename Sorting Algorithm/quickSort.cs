public void QuickSort(int[] array, int start, int end)
{
	if (start < end)
	{
		int partitionIndex = Partition(array, start, end);

		QuickSort(array, start, partitionIndex - 1);
		QuickSort(array, partitionIndex + 1, end);
	}
}

public int Partition(int[] array, int start, int end)
{
	int pivot = array[end];
	int index = start - 1;

	for (int i = start; i <= end; i++)
	{
		if (array[i] <= pivot)
		{
			index++;
			int temp = array[index];
			array[index] = array[i];
			array[i] = temp;
		}
	}

	return index;
}