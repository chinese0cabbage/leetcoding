#pragma once
//算法描述
//称每两个相邻的相同字符为相同字符组，最长无重复字符的字符串实际上为前后相邻两个相同字符组的起始位置加一到结束位置减一

void SetMin(int* goal, int num1, int num2) {//取两个中较小且大于goal的值
	if (num1 > num2)
		num1 = num2;
	if (*goal < num1)
		*goal = num1;
}


int lengthOfLongestSubstring(char* s) {
	char end = '\0';
	if (s[0] == end)
		return 0;//空串
	int longest = 0, i = -1;
	int sameCharPlace[2][3] = { 0 };//储存相邻两个相同字符的位置
	int charArray[128];//哈希表，用于查找上一个重复的字符所在位置
	int firstStr = 1;//表示当前遍历位置是否已经出现过第一次重复
	for (int j = 0; j < 128; j++) charArray[j] = -1;
	while (s[++i] != end) {
		if (charArray[(int)s[i]] != -1) {//查找到了重复元素
			firstStr = 0;
			SetMin(&longest, sameCharPlace[1][2] - sameCharPlace[0][1], sameCharPlace[1][2] - sameCharPlace[1][1]);
			sameCharPlace[0][0] = sameCharPlace[1][0];
			sameCharPlace[0][1] = sameCharPlace[1][1];
			sameCharPlace[0][2] = sameCharPlace[1][2];//将第二个位置的三个元素放到第一个位置
			sameCharPlace[1][0] = (int)s[i];
			sameCharPlace[1][1] = charArray[(int)s[i]];
			sameCharPlace[1][2] = i;//新查找到的重复元素放到第二个位置
		}
		else {
			if (firstStr)
				sameCharPlace[1][2]++;
		}
		charArray[(int)s[i]] = i;
	}
	SetMin(&longest, sameCharPlace[1][2] - sameCharPlace[0][1], sameCharPlace[1][2] - sameCharPlace[1][1]);
	SetMin(&longest, i - sameCharPlace[1][1] - 1, i - sameCharPlace[0][1] - 1);
	return longest;
}