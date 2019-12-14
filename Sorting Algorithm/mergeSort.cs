public void MergeSort(int[] array, int length)
{
	Split(array, length);
}

public void Split(int[] array, int length)
{
	if (length < 2)
	{
		return;
	}

	int midIndex = length / 2;
	int[] left = new int[midIndex];
	int[] right = new int[length - midIndex];

	for (int i = 0; i < midIndex; i++)
	{
		left[i] = array[i];
	}
	for (int j = midIndex; j < length; j++)
	{
		right[j - midIndex] = array[j];
	}

	Split(left, left.Length);
	Split(right, right.Length);

	Merge(left, right, array);
}

public void Merge(int[] left, int[] right, int[] array)
{
	int i = 0;
	int j = 0;
	int k = 0;
	while (i < left.Length && j < right.Length)
	{
		if (left[i] <= right[j])
		{
			array[k] = left[i];
			i++;
		}
		else
		{
			array[k] = right[j];
			j++;
		}
		k++;
	}
	while (i < left.Length)
	{
		array[k] = left[i];
		i++;
		k++;
	}
	while (j < right.Length)
	{
		array[k] = right[j];
		j++;
		k++;
	}
}