using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player_Controller : MonoBehaviour
//Player_Controller Ŭ������ MonoBehaviour ���
{
    public float speed = 5f;
    //float speed ������ ���� 5f(���̻�)�� �Ҵ�
    float BulletSpeed = 12.5f;
    public GameObject Bulletfrefab;
    float time;


    void Update() //����(��) �ֱ⸶�� ������ ȣ��
    {
        float x = Input.GetAxis("Horizontal");
        //float x ������ Horizontal���� �Է°��� �Ҵ� �� Input �ý��ۿ� ��ȯ�� �� ó��
        float z = Input.GetAxis("Vertical");
        //float z ������ Vertical���� �Է°��� �Ҵ� �� Input �ý��ۿ� ��ȯ�� �� ó��

        Vector3 Move = new Vector3(x, 0, z);
        //Vector3 Move ������ Vector3() ���� �� Vector3�� �Ű������� �Ҵ�

        transform.Translate(Move * speed * Time.deltaTime);
        //transform.Translate �Լ��� ����Ͽ� Move * speed * Time.deltaTime�� ������ ��ġ�� ����
        BulletMove();

    }
    void BulletMove()
    {
        time += Time.deltaTime;
        Debug.Log("Shoot");
        if (time > 0.3f) {
            GameObject Bullet = Instantiate(Bulletfrefab, transform.position, Quaternion.identity);
            Bullet.transform.Translate(Vector3.forward * BulletSpeed * Time.deltaTime);
            time -= 0.3f;
        }
    }
}
