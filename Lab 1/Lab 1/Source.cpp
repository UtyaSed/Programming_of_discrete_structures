#include <iostream>

using namespace std;

void printch(int* x)
{
	for (int i = 0; i < 10; i++)
		cout << x[i];
	cout << endl;
}
void oper_or(int* fir, int* sec, int* operation)
{
	for (int i = 0; i < 10; i++)
	{
		if (fir[i] == 1 || sec[i] == 1)
			operation[i] = 1;
		else
			operation[i] = 0;
	}
}
void oper_and(int* fir, int* sec, int* operation)
{
	for (int i = 0; i < 10; i++)
	{
		if (fir[i] == 1 && sec[i] == 1)
			operation[i] = 1;
		else
			operation[i] = 0;
	}
}
void oper_xor(int* fir, int* sec, int* operation)
{
	for (int i = 0; i < 10; i++)
	{
		if (fir[i] == 1 && sec[i] == 1 || fir[i] == 0 && sec[i] == 0)
			operation[i] = 0;
		else
			operation[i] = 1;
	}
}
int main()
{
	const int n = 10;
	int fir[n] = { 1, 1, 0, 0, 0, 1, 1, 1, 0, 0 };
	int sec[n] = { 1, 0, 1, 0, 1, 0, 1, 1, 1, 0 };
	int operation[n];

	printch(fir);
	printch(sec);
	cout << "or:" << endl;
	oper_or(fir, sec, operation);
	printch(operation);
	cout << "and:" << endl;
	oper_and(fir, sec, operation);
	printch(operation);
	cout << "xor:" << endl;
	oper_xor(fir, sec, operation);
	printch(operation);
}