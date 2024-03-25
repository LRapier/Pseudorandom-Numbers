using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomize : MonoBehaviour
{
    public GameObject[] objects = new GameObject[100];
    void Start()
    {
        objects = GameObject.FindGameObjectsWithTag("Obj");
        PureRandom();
    }

    public void PureRandom()
    {
        foreach(GameObject obj in objects)
        {
            Transform objPos = obj.transform;
            objPos.position = new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f));
        }
    }
}
