using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    public Transform cameraPos;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = cameraPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
