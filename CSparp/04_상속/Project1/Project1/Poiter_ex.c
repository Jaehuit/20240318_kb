#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

//����::5���� ������ ��� �Է� ���� ��, �������鿡 �����ѹ��� ��ȸ�ϸ�
	//     60�̸��� ���� �߰ߵǸ� 60���� ���� ����.
	//     �� �� 5���� ������ ���� ��հ��� ���ϱ�
	//     []��ȣ�� ������ �迭�� ������ ���� ����Ͽ���.

int main() {
	int score[5]; //5���� �ּҰ��� ���� �� ����
	int* pscore = score;
	for (int i = 0;i < 5;i++) {
		//scanf("%d", *pscore[i]);
		scanf("%d", *pscore + i); //pscore::pscore�� �����ּ�(�Ϲݹ迭�� �׷���)
	}
	//60�Ʒ��� ���� 60���� ����
	for (int i = 0;i < 5;i++) {
		if (*(pscore + i) < 60) {
			*(pscore + i) = 60;
		}
	}
	// 5���� ������ ���Ͽ� ��հ��� ���϶�
	double result = 0;
	for (int i = 0;i < 5;i++) {
		result += *pscore+i;
	}
	printf("��հ�::%1f", result / 5);
}