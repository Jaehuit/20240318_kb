#include<stdio.h>

//����::���丮��
	//"n�� �Է¹ް�, n! ���� ���϶�
	//n! = n*(n-1)* ..*2*1

	//1.n�Է�


	
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
		printf("�����::%d",result);


}