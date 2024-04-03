#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

//예제::5개의 성적을 모두 입력 받은 뒤, 성적값들에 대해한번씩 순회하며
	//     60미만의 값이 발견되면 60으로 값을 변경.
	//     그 후 5개의 성적에 대한 평균값을 구하기
	//     []기호는 포인터 배열을 선언할 때만 사용하여라.

int main() {
	int score[5]; //5개의 주소값을 가질 수 있음
	int* pscore = score;
	for (int i = 0;i < 5;i++) {
		//scanf("%d", *pscore[i]);
		scanf("%d", *pscore + i); //pscore::pscore의 시작주소(일반배열도 그러함)
	}
	//60아래의 값을 60으로 수정
	for (int i = 0;i < 5;i++) {
		if (*(pscore + i) < 60) {
			*(pscore + i) = 60;
		}
	}
	// 5개의 성적에 대하여 평균값을 구하라
	double result = 0;
	for (int i = 0;i < 5;i++) {
		result += *pscore+i;
	}
	printf("평균값::%1f", result / 5);
}