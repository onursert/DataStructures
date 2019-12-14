public void SelectionSort(int[] array, int length)
{
	//lenght-1 because there is no need to compare the last element of the list.
	//Because it will be replaced before already.
	for (int i = 0; i < length - 1; i++)
	{
		int min = i;

		//i+1 because there is no need to compare 2 same position.
		for (int j = i + 1; j < length; j++)
		{
			if (array[j] < array[min])
			{
				min = j;
			}
		}

		if (min != i)
		{
			int temp = array[min];
			array[min] = array[i];
			array[i] = temp;
		}
	}
}