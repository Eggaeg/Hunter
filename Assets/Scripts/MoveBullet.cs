using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    private int speed = 10;
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
