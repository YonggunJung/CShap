#include <stdio.h>
#define _CRT_SECURE_NO_WARNINGS

const int m_day_normal[] = {0, 31, 28, 31, 30 , 31, 30 , 31, 31, 30 , 31, 30 , 31 };
const int m_day_yoon[] = { 0, 31, 29, 31, 30 , 31, 30 , 31, 31, 30 , 31, 30 , 31 };

int is_yoon(int y) 
{
	return (y % 4 == 0 && y % 100 != 0) || y % 400 == 0;
}

int wd_1_1(int y) 
{
	int wd = 1 + (y - 1900);
	for (int i = 1904; i < y; i += 4) 
	{
		if (is_yoon(i))
			wd++;
	}
	return wd % 7;
}

int wd_month(int m, int days[])
{
	int wd = 0;
	for (int i = 1;i< m;i++)
	{
		wd += days[i];
	}
	return wd % 7;
}

void calendar(int y, int m)
{
	int yoon = is_yoon(y);
	int* m_days = yoon ? m_day_yoon : m_day_normal;

	int wd = (wd_1_1(y) + wd_month(m, m_days)) % 7;
	int days = m_days[m];
	int w = 0;

	char cal[6][7][4] = {0};		// null로 초기화
	for (int i = 0; i < 7; i++)
	{
		sprintf(cal[0][i], "   ");
	}

	for (int i = 1; i <= days; i++)
	{
		sprintf(cal[w][wd], "%3d", i);

		if (++wd > 6)
		{
			wd = 0;
			w++;
		}
	}
	for (int i = 0; i < 6; i++)
	{
		for (int j = 0; j < 7; j++)
		{
			printf(cal[i][j]);
		}
		printf('\n');
	}
}

int main()
{
	calendar(2024, 4);
}