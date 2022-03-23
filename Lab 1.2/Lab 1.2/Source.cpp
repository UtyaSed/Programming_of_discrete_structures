#include <iostream>
#include <string>

using namespace std;

void true_false(bool p, bool q) {

	bool result = false;
	bool p_implication = false;
	bool q_implication = false;


	cout << "Conjunction: ";
	if (p == q && p == true) 
	{
		result = true;
		cout << "True" << endl;
	}
	else
	{
		result = false;
		cout << "False" << endl;
	}


	cout << "Disjunction:";
	if (p == q && p == false) 
	{
		result = false;
		cout << "False" << endl;
	}
	else 
	{
		result = true;
		cout << "True" << endl;
	}


	cout << "XOR: ";
	if (p != q) 
		
	{
		result = true;
		cout << "True" << endl;
	}
	else 
	{
		result = false;
		cout << "False" << endl;
	}


	cout << "Implication: ";
	if (p == false) 
	{
		p_implication = true;
	}
	else
	{
		p_implication = false;
	}

	if (p_implication == q && p_implication == false) 
	{
		result = false;
		cout << "False" << endl;
		
	}
	else 
	{
		result = true;
		cout << "True" << endl;
	}


	cout << "Reverse Implication: ";
	if (q == false) 
	{
		q_implication = true;
	}
	else 
	{
		q_implication = false;
	}

	if (p == q_implication && p == false) 
	{
		result = false;
		cout << "False" << endl;
	}
	else 
	{
		result = true;
		cout << "True" << endl;
	}


}

int main()
{

	bool p = false;
	bool q = false;

	string p_checker = "";
	string q_checker = "";

	cout << "p:" << endl;

	cin >> p_checker;

	if (p_checker == "true" || p_checker == "True" || p_checker == "1") 
	{
		p = true;
	}
	else 
		if (p_checker == "false" || p_checker == "False" || p_checker == "0") 
		{
		p = false;
		}

	cout << "q:" << endl;

	cin >> q_checker;

	if (q_checker == "true" || q_checker == "True" || q_checker == "1") 
	{
		q = true;
	}
	else 
		if (q_checker == "false" || q_checker == "False" || q_checker == "0") 
		{
		q = false;
		}

	cout << "--------------------------------" << endl << endl;

	true_false(p, q);

}