#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

// C/C++�� ������Ʈ ������ ����
int main() {
	// ������:: ����Ű�� ��
	// &(�ּҿ�����), *
	int num = 5;
	printf("��::%d\n",num);
	printf("�ּҰ�::%d\n\n", &num); 
	//&::������ �޸� �ּ� ��ȯ
	
	//������ ����::Ư�� �޸𸮸� ����Ű�� ����
	//-num�� ����Ű�� ���� ����
	int* pnum;  //��� ������ ����Ű�� "pnum"���� ����
	pnum = &num;
	printf("�׳� pnum���::%d\n",pnum);
	printf("*pnum ���::%d\n", *pnum);

	//����::5���� ������ ��� �Է� ���� ��, �������鿡 �����ѹ��� ��ȸ�ϸ�
	//     60�̸��� ���� �߰ߵǸ� 60���� ���� ����.
	//     �� �� 5���� ������ ���� ��հ��� ���ϱ�
	//     []��ȣ�� ������ �迭�� ������ ���� ����Ͽ���.
	int* pscore[5];
    int sum = 0;

   // int scores[5];
   // int sum = 0;
    int pscore = 60;
    int* pscore[5]=pscore;



    // ���� �Է� �ޱ�
    printf("5���� ������ �Է��ϼ���:\n");
   // for (int i = 0; i < 5; i++) {
   //     scanf("%d", &scores[i]);
   // }
    for (int i = 0; i < 5; i++) {
        scanf("%d", &pscore[i]);
    }

    // 60 �̸��� �� ó��
    //for (int i = 0; i < 5; i++) {
    //    if (scores[i] < 60) {
    //        scores[i] = 60;
    //    }
    //}
    if (pscore[i] < 60) {
             pscore[i] = 60;


    // ��� ���ϱ�
    for (int i = 0; i < 5; i++) {
        //sum += scores[i];
        sum += pscore[i];
    }
    int average = sum / 5;

   /* printf("ó���� ����:\n");
    for (int i = 0; i < 5; i++) {
        printf("%.2d ", scores[i]);
    }
   */ printf("\n��� ����: %.2d\n", average);

    return 0;
}

