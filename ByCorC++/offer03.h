#pragma once
int findRepeatNumber(int* nums, int numsSize) {
	int tmp, index;
	for (int i = 0; i < numsSize; i++)
	{
		index = nums[i];
		if (nums[index] == index && index != i)
			return index;
		else
		{
			while (index != nums[index])
			{
				tmp = nums[index];
				nums[index] = index;
				index = tmp;
				nums[i] = index;
			}
		}
	}
}