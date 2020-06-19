#pragma once
int lengthOfLongestSubstring(char* s) {
	char end = '\0';
	if (s[0] == end)
		return 0;
	int i = -1, charArr[52] = { -1, -1,-1, -1,-1, -1,-1, -1, -1, -1,-1, -1,-1, -1,-1, -1,-1, -1,-1, -1,-1, -1,-1, -1, -1, -1,-1, -1,-1, -1,-1, -1,-1, -1,-1, -1,-1, -1,-1, -1, -1, -1,-1, -1,-1, -1,-1, -1,-1, -1,-1, -1 }, longest = 1;
	while (s[++i] != end) {
		if (s[i] == ' ')
			continue;
		if (int(s[i]) >= 97) {//Ð¡Ð´×ÖÄ¸
			if (charArr[int(s[i]) - 71] != -1 && i - charArr[int(s[i]) - 71] > longest)
				longest = i - charArr[int(s[i]) - 71];
			charArr[int(s[i]) - 71] = i;
		}
		else {//´óÐ´×ÖÄ¸
			if (charArr[int(s[i]) - 65] != -1 && i - charArr[int(s[i]) - 65] > longest)
				longest = i - charArr[int(s[i]) - 65];
			charArr[int(s[i]) - 65] = i;
		}
	}
	return longest;
}