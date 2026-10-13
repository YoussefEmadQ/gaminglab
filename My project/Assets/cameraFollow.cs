using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    public float cameraSpeed;
    float minX;
    float maxX;
    float minY;
    float maxY;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (target != null)
        {
            Vector2 newCamPosition=Vector2.Lerp(transform.position, target.position, cameraSpeed * Time.deltaTime);
        }
    }
}
