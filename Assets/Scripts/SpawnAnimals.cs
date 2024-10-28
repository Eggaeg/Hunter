using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimals : MonoBehaviour
{
    public GameObject[] animals;

    private int index;
    private Vector3 position;

    private void Start()
    {
        InvokeRepeating("Spawn", 2, 5);
    }
    
    void Spawn()
    {
        position = new Vector3(Random.Range(48.7f, 7.32f), 10, 0);
        index = Random.Range(0, animals.Length);
        Instantiate(animals[index], position,animals[index].transform.rotation);
    }
}
