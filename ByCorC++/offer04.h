#pragma once
bool findNumberIn2DArray(int** matrix, int matrixSize, int* matrixColSize, int target) {
	int high, low = 0, mid;
	if (matrixSize > * matrixColSize)
		high = *matrixColSize;
	else
		high = matrixSize;
	mid = (high + low) / 2;
	while (mid >= 0 && mid < high) {//���������ҵ�ֵ����������������֮��
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
	if (mid == high) {//�������������û��ֹͣ����������Ҫ���ն��ֲ�����������һ�л���
		if (high == matrixSize) {
			low = matrixSize, high = *matrixColSize, mid = (low + high) / 2;
			while (mid >= low && mid < high) {

			}
		}
	}
	else {//��δ�����������ֹͣ������֤��Ҫ���ҵ�ֵ��mid�������е��Ϸ�����ߣ��ֱ���ж��ֲ���

	}
}