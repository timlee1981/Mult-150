using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        float xMov = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(xMov * speed * Time.deltaTime, 0, 0));
    }
}
