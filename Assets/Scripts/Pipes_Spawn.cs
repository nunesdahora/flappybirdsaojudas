using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes_Spawn : MonoBehaviour
{
    
    public GameObject objPrefab;
    public float height;
    public float maxTime;

    private float timer = 0f;

    void Start()
    {
        GameObject newobj = Instantiate(objPrefab);
        newobj.transform.position = transform.position + new Vector3 (0, Random.Range(-height, height), 0);
    }

    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newobj = Instantiate(objPrefab);
            newobj.transform.position = transform.position + new Vector3 (0, Random.Range(-height, height), 0);
            Destroy(newobj, 20f);
            timer = 0;   
        }
        timer += Time.deltaTime;   
    }
}
