#include <iostream>

using namespace std;

void oper_qr(int* q, int* r, int* qr, const int n)
{
	for (int i = 0; i < n; i++)
	{
		if (q[i] == 1 && r[i] == 1 )
			qr[i] = 1;
		else qr[i] = 0;
	}
}
void oper_pqr(int* qr, int* p, int* pqr, const int n)
{
	for (int i = 0; i < n; i++)
	{
		if ((p[i] == 0 && qr[i] == 0) || (p[i] == 1 && qr[i] == 1))
		{
			pqr[i] = 0;
		}
		else
		{
			pqr[i] = 1;
		}
	}
}
int main()
{
	const int n = 8;
	int p[n] = { 0,0,0,0,1,1,1,1 };
	int q[n] = { 0,0,1,1,0,0,1,1 };
	int r[n] = { 0,1,0,1,0,1,0,1 };
	int qr[n];
	int pqr[n];
	oper_qr(q, r, qr, n);
	oper_pqr(qr, p, pqr, n);
	cout << "           p xor (q and r)" << endl << endl;;
	cout << "-------------------------------------------" << endl;
	cout << "| p | q | r | q and r | p xor ( q and r ) |" << endl;
	cout << "-------------------------------------------" << endl;
	for (int i = 0; i < n; i++)
	{
		cout << "| " << p[i] << " | " << q[i] << " | " << r[i] << " |   " << qr[i] << "     |        " << pqr[i] << "          |" << endl;
	}
	cout << "-------------------------------------------" << endl;
}
