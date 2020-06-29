#pragma once
int reverse(int x) {
	__int32 result = 0;
	int greaterThanZero = 1;
	if (x < 0)
	{
		greaterThanZero = 0;
		x = -x;
	}
	while (x != 0) {
		result = result * 10 + x % 10;
		x /= 10;
	}
	if (!greaterThanZero)
		return -result;
	return result;
}