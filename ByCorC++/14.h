#pragma once
#include<malloc.h>
typedef struct CharChain {
	char ch;
	CharChain* next;
}CharChain;

char* longestCommonPrefix(char** strs, int strsSize) {
	char end = '\0', commonCh, tmp;
	int commonNum = 0;
	CharChain* head = (CharChain*)malloc(sizeof(CharChain));
	while (1) {
		commonCh = strs[0][commonNum];
		if (commonCh == end)
			break;
		for (int i = 1; i < strsSize; i++)
		{
			tmp = strs[i][commonNum];
			if (tmp == end || tmp != commonCh)
				break;
		}
		if (tmp != end && tmp == commonCh)
			;
	}
}