#define CRT_SECURE_NO_WARNINGS
#include <stdio.h>

// sudio.h ::����� �Լ� �����ϴ� ���̺귯��

int main() {
    // ���α׷� ���� �� ������ ��ɾ main���� �ۼ�

    // ����� ::printf() scanf()
    int num;   //������
    char ch;   //������(C���� String���� ����)
    double d;  //�Ǽ���
    // int -> char-> double ������ �Է�
    scanf("%d %c %lf ", &num, &ch, &d);
    // %c::������ �Է¹��� �� �ִ�

    printf("Hello world!\n");
    printf("������::%d", num);
    printf("���ڰ�::%c", ch);
    printf("�Ǽ���::%lf", d); // double�� ��½� %f ����ص� ����




}