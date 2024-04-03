#include<stdio.h>

//예제::팩토리얼
	//"n을 입력받고, n! 값을 구하라
	//n! = n*(n-1)* ..*2*1

	//1.n입력


	
	int factorial(int n) {
		if (n == 1) { return 1; }
		else {
			return n * factorial(n - 1);
		}

	}
	int main() {
		int n;
		scanf("");

		int result = factorial(n);
		printf("결과값::%d",result);


}