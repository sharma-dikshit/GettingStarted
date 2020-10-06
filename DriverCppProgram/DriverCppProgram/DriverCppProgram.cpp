#include <Windows.h>
#include <iostream>
#include <string>
#include "tchar.h"


#import "C:\FundamentalMathematicalOperations.tlb" raw_interfaces_only

using namespace FundamentalMathematicalOperations;

int main()
{
	HRESULT hr = CoInitialize(NULL);

	long sum;
	long product;
	double quotient;
	long difference;

	IAdditionPtr pIAdd(__uuidof(Addition));
	ISubstractionPtr pISub(__uuidof(Substraction));
	IMultiplicationPtr pIMul(__uuidof(Multiplication));
	IDivisionPtr pIDiv(__uuidof(Division));

	int num1, num2;

	std::cout << "Enter two numbers : ";
	std::cin >> num1 >> num2;

	pIAdd->SumTwoNumbers(num1, num2, &sum);
	pISub->SubstractTwoNumbers(num1, num2, &difference);
	pIMul->MultiplyTwoNumbers(num1, num2, &product);
	pIDiv->DivideTwoNumbers(num1, num2, &quotient);

	std::cout << "The sum is : " << sum << std::endl;
	std::cout << "The difference is : " << difference << std::endl;
	std::cout << "The product is : " << product << std::endl;
	std::cout << "The quotient is : " << quotient << std::endl;

	CoUninitialize();

	return 0;
}