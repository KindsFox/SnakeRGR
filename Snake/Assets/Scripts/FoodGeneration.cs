using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGeneration : MonoBehaviour
{
    public float XSize = 8.8f;
    public float ZSize = 8.8f;
    public GameObject fodPrefab;
    public GameObject curFood;
    public GameObject child;
    public Vector3 curPos;

    private void Start()
    {
        child = fodPrefab.transform.GetChild(0).gameObject;
    }

    void Update()
    {
        if(!child.activeSelf)
        {
            AddNewFood();
        }
        else
        {
            return;
        }
    }

    void AddNewFood()
    {
        RandomPosition();
        child.transform.position = curPos;
        child.SetActive(true);            
    }
    void RandomPosition()
    {
        curPos = new Vector3(Random.Range(XSize*-1, XSize),0.25f,Random.Range(ZSize*-1, ZSize));
    }  
}
