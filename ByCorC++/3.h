#pragma once
//�㷨����
//��ÿ�������ڵ���ͬ�ַ�Ϊ��ͬ�ַ��飬����ظ��ַ����ַ���ʵ����Ϊǰ������������ͬ�ַ������ʼλ�ü�һ������λ�ü�һ

void SetMin(int* goal, int num1, int num2) {//ȡ�����н�С�Ҵ���goal��ֵ
	if (num1 > num2)
		num1 = num2;
	if (*goal < num1)
		*goal = num1;
}


int lengthOfLongestSubstring(char* s) {
	char end = '\0';
	if (s[0] == end)
		return 0;//�մ�
	int longest = 0, i = -1;
	int sameCharPlace[2][3] = { 0 };//��������������ͬ�ַ���λ��
	int charArray[128];//��ϣ�����ڲ�����һ���ظ����ַ�����λ��
	int firstStr = 1;//��ʾ��ǰ����λ���Ƿ��Ѿ����ֹ���һ���ظ�
	for (int j = 0; j < 128; j++) charArray[j] = -1;
	while (s[++i] != end) {
		if (charArray[(int)s[i]] != -1) {//���ҵ����ظ�Ԫ��
			firstStr = 0;
			SetMin(&longest, sameCharPlace[1][2] - sameCharPlace[0][1], sameCharPlace[1][2] - sameCharPlace[1][1]);
			sameCharPlace[0][0] = sameCharPlace[1][0];
			sameCharPlace[0][1] = sameCharPlace[1][1];
			sameCharPlace[0][2] = sameCharPlace[1][2];//���ڶ���λ�õ�����Ԫ�طŵ���һ��λ��
			sameCharPlace[1][0] = (int)s[i];
			sameCharPlace[1][1] = charArray[(int)s[i]];
			sameCharPlace[1][2] = i;//�²��ҵ����ظ�Ԫ�طŵ��ڶ���λ��
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