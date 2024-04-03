#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

// C/C++은 프로젝트 단위로 실행
int main() {
	// 포인터:: 가리키는 것
	// &(주소연산자), *
	int num = 5;
	printf("값::%d\n",num);
	printf("주소값::%d\n\n", &num); 
	//&::변수의 메모리 주소 반환
	
	//포인터 변수::특정 메모리를 가리키는 변수
	//-num을 가리키는 변수 생성
	int* pnum;  //어느 지점을 가리키는 "pnum"변수 생성
	pnum = &num;
	printf("그냥 pnum출력::%d\n",pnum);
	printf("*pnum 출력::%d\n", *pnum);

	//예제::5개의 성적을 모두 입력 받은 뒤, 성적값들에 대해한번씩 순회하며
	//     60미만의 값이 발견되면 60으로 값을 변경.
	//     그 후 5개의 성적에 대한 평균값을 구하기
	//     []기호는 포인터 배열을 선언할 때만 사용하여라.
	int* pscore[5];
    int sum = 0;

   // int scores[5];
   // int sum = 0;
    int pscore = 60;
    int* pscore[5]=pscore;



    // 성적 입력 받기
    printf("5개의 성적을 입력하세요:\n");
   // for (int i = 0; i < 5; i++) {
   //     scanf("%d", &scores[i]);
   // }
    for (int i = 0; i < 5; i++) {
        scanf("%d", &pscore[i]);
    }

    // 60 미만인 값 처리
    //for (int i = 0; i < 5; i++) {
    //    if (scores[i] < 60) {
    //        scores[i] = 60;
    //    }
    //}
    if (pscore[i] < 60) {
             pscore[i] = 60;


    // 평균 구하기
    for (int i = 0; i < 5; i++) {
        //sum += scores[i];
        sum += pscore[i];
    }
    int average = sum / 5;

   /* printf("처리된 성적:\n");
    for (int i = 0; i < 5; i++) {
        printf("%.2d ", scores[i]);
    }
   */ printf("\n평균 성적: %.2d\n", average);

    return 0;
}

