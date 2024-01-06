using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Controller : MonoBehaviour
{
    public float Speed;
    float time;
    void Start()
    {
        time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        FireBullet();
        DestroyBullet();
    }

    private void FireBullet()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }

    void DestroyBullet()
    {
        time += Time.deltaTime;
        if (time > 3.0f)
        {
            Destroy(gameObject);
        }
    }
}

