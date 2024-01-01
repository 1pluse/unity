using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Character_Move: MonoBehaviour
//Character_Move 클래스의 MonoBehaviour 상속
{
    public float speed = 5f; 
    //float speed 변수의 값을 5f(접미사)로 할당

    void Update() //랜덤(매) 주기마다 프레임 호출
    {
        float x = Input.GetAxis("Horizontal");
        //float x 변수의 Horizontal축의 입력값을 할당 후 Input 시스템에 반환된 후 처리
        float z = Input.GetAxis("Vertical");
        //float z 변수의 Vertical축의 입력값을 할당 후 Input 시스템에 반환된 후 처리

        Vector3 Move = new Vector3(x, 0, z);
        //Vector3 Move 변수의 Vector3() 생성 후 Vector3의 매개변수를 할당
        
        transform.Translate(Move * speed * Time.deltaTime);
        //transform.Translate 함수를 사용하여 Move * speed * Time.deltaTime의 값으로 위치를 변경
    }
}
