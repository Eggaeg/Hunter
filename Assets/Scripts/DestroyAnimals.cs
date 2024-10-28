using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAnimals : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Animal"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
