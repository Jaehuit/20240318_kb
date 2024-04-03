#define CRT_SECURE_NO_WARNINGS
#include <stdio.h>

// sudio.h ::입출력 함수 포함하는 라이브러리

int main() {
    // 프로그램 실행 시 수행할 명령어를 main에서 작성

    // 입출력 ::printf() scanf()
    int num;   //정수형
    char ch;   //문자형(C언어에는 String형이 없음)
    double d;  //실수형
    // int -> char-> double 순으로 입력
    scanf("%d %c %lf ", &num, &ch, &d);
    // %c::공백을 입력받을 수 있다

    printf("Hello world!\n");
    printf("정수값::%d", num);
    printf("문자값::%c", ch);
    printf("실수값::%lf", d); // double형 출력시 %f 사용해도 무관




}