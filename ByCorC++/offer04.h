#pragma once
bool findNumberInMatrix(int** matrix, int rowMin, int rowMax, int colMin, int colMax, int target);
bool findNumberIn2DArray(int** matrix, int matrixSize, int* matrixColSize, int target) {
	return findNumberInMatrix(matrix, 0, matrixSize - 1, 0, *matrixColSize - 1, target);
}

bool findNumberInMatrix(int** matrix, int rowMin, int rowMax, int colMin, int colMax, int target) {
	if (rowMax - rowMin == colMax - colMin) {//方阵
		int rowHigh = rowMax, rowLow = rowMin, colHigh = colMax, colLow = colMin,
			rowMid = (rowHigh + rowLow) / 2, colMid = (colHigh + colLow) / 2;
		while (rowMid < rowMax && rowMid >= rowMin) {//行和列的大小一样且同增同减
			if (matrix[rowMid][colMid] == target) {
				return true;
			}
			else if (matrix[rowMid][colMid] > target) {
				rowHigh = rowMid - 1, colHigh = colMid - 1;
			}
			else {
				rowLow = rowMid + 1, colLow = colMid + 1;
			}
			rowMid = (rowHigh + rowLow) / 2, colMid = (colHigh + colLow) / 2;
		}
	}
	return true;
}