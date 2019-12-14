public void BubbleSort(int[] array, int length)
{
	bool changed = true;
	//While loop runs, while list changed by for loop.
	//We assume that changed will be false everytime when we start while loop (We assume there will be no changes in the list). If it stays same i mean changed will stay false while loop will be broke.
	while (changed)
	{
		changed = false;
		for (int i = 0; i < length - 1; i++)
		{
			if (array[i + 1] < array[i])
			{
				int temp = array[i];
				array[i] = array[i + 1];
				array[i + 1] = temp;

				changed = true;
			}
		}
		length--;
	}
}