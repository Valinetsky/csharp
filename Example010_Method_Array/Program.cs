// 				 0    1   2  3   4  5   6    7   8
int[] array = { 14, 325, 37, 4, 15, 6, 47, 998, 19 };

int n = array.Length;
int find = 47;

int index = 0;

while (index < n)
{
	if (array[index] == find)
	{
		Console.WriteLine(index);
		break;
	}
	index++;
}