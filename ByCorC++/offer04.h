#pragma once
bool findNumberIn2DArray(int** matrix, int matrixSize, int* matrixColSize, int target) {
	int high, low = 0, mid;
	if (matrixSize > * matrixColSize)
		high = *matrixColSize;
	else
		high = matrixSize;
	mid = (high + low) / 2;
	while (mid >= 0 && mid < high) {//搜索欲查找的值在左上那两个方阵之间
		if (matrix[mid][mid] == target) {
			return true;
		}
		else if (matrix[mid][mid] > target)
		{
			if (matrix[mid - 1][mid - 1] < target)
				break;
			else
				high = mid - 1;
		}
		else {
			low = mid + 1;
		}
		mid = (high + low) / 2;
	}
	if (mid == high) {//到达最大方阵依旧没有停止搜索，则需要按照二分查找搜索在那一行或列
		if (high == matrixSize) {
			low = matrixSize, high = *matrixColSize, mid = (low + high) / 2;
			while (mid >= low && mid < high) {

			}
		}
	}
	else {//还未到达最大矩阵就停止搜索，证明要查找的值在mid所在行列的上方与左边，分别进行二分查找

	}
}