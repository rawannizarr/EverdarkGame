using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spheres;
    public Transform[] points;
    public float beat = 60 / 130;
    private float timer;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > beat)
        {
            int sphereIndex = Random.Range(0, spheres.Length);
            int pointsIndex = Random.Range(0, points.Length);

            Instantiate(spheres[sphereIndex], points[pointsIndex]);
            

            timer = 0;

        }
        timer += Time.deltaTime;
        
    }


}
