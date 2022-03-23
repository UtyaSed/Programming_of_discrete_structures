#include <iostream>
#include <string>
#include <iomanip>
#include <algorithm>
#include <vector>

using namespace std;

int Factorial(int numb) 
{
	int result = 1;
	for (int k = 1; k <= numb; k++) {
		result *= k;
	}
	return result;
}

void Permutation(int n)
{
	int* i = new int[n];
	for (int k = 0; k < n; k++) 
	{
		i[k] = k + 1;
	}

	sort(i, i + n);
	cout << n << "! (" << Factorial(n) << ") permutations with " << n << " elements:" << endl;
	do
	{
		for (int k = 0; k < n; k++)
		{
			cout << i[k] << " ";
		}
		cout << endl;
	} 
	while (next_permutation(i, i + n));
}

void Combination(int an, int ar)
{
	vector<bool> v(an);

	fill(v.begin(), v.begin() + ar, true);

	cout << an << "! / (" << ar << "! * (" << an << " - " << ar << ")) \n (" << Factorial(an) / (Factorial(ar) * Factorial(an - ar)) << ") Combinations with " << an << " by " << ar << ":" << endl;
	do 
	{
		for (int i = 0; i < an; ++i) 
		{
			if (v[i]) 
			{
				cout << (i + 1) << " ";
			}
		}
		cout << endl;
	} 
	while (prev_permutation(v.begin(), v.end())); 
}

int main()
{
	int n = 0;
	cout << "n = ";
	cin >> n;

	Permutation(n);

	int an = 0;
	int ar = 0;
	cout << "\n ";
	cout << "Part 2:\n";

	cout << "with = ";
	cin >> an;
	cout << "by = ";
	cin >> ar;
	cout << "\n ";
	ar = abs(ar);

	Combination(an, ar);
}