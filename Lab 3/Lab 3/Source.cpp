#include <iostream>
#include <iomanip>

using namespace std;


int Factorial(int x)
{
	int result = 1;
	for (int i = 1; i <= x; i++)
	{
		result = result * i;
	}
	return result;
}

void PartOne()
{
	int n = 9;
	int r = 4;
	int numeral = Factorial(n); // числівник
	int denominator = Factorial(n - r); // знаменник
	int a = numeral / denominator;
	cout << "Part 1: " << "\n n = " << n << "\n r = " << r << "\n A = " << a << endl << endl;
}



void Stirling(int** F, int n)
{
	for (int j = 0; j < n; j++)
	{
		F[j][0] = 1;
		F[j][j] = 1;
	}

	for (int j = 2; j < n; j++)
		for (int k = 1; k < j; k++)
		{
			F[j][k] = F[j - 1][k - 1] + (k + 1) * F[j - 1][k];
		}
	for (int j = 0; j < n; j++)
		for (int k = 0; k < n; k++)
			if (F[j][k] < 0)
				F[j][k] = 0;
}

void Bell(int** F, int* B, int n)
{
	for (int j = 0; j < n; j++)
		B[j] = 0;

	for (int j = 0; j < n; j++)
		for (int k = 0; k < j; k++)
		{
			B[j] = B[j] + F[j][k];
		}
}

void print(int** F, int* B, int n)
{
	cout << " |";
	for (int i = 0; i < n; i++)
		cout << setw(6) << i + 1 << "|";
		cout << setw(6) << "Bell" << endl;

	for (int i = 0; i < n; i++)
	{
		cout << i + 1 << "|";
		for (int j = 0; j < n; j++)
		{
			if (F[i][j] == 0)
				cout << setw(6) << "" << "|";

			else cout << setw(6) << F[i][j] << "|";
		}
		cout << setw(6) << B[i];
		cout << endl;
	}
	cout << endl;

}

void PartTwo()
{
	int i = 7;
	int n = i + 5;
	int** F = new int* [n];
	for (int j = 0; j < n; j++)
		F[j] = new int[n];

	int* B = new int[n];

	cout << "Part 2: \n";

	Stirling(F, n);
	Bell(F, B, n);
	print(F, B, n);
}

int main()
{
	PartOne();

	PartTwo();
}