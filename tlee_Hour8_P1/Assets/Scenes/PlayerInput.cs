using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");
        if(hVal != 0)
        {
            print("h movement: " + hVal);

        }
        if(vVal != 0)
        {
            print("v movement: " + vVal);
            
        }
        if(Input.GetKey(KeyCode.M))
        {
            print("M pressed");
        }
        if(Input.GetKeyDown(KeyCode.O))
        {
            print("O pressed");
        }
        float myxVal = Input.GetAxis("Mouse X");
        float myyVal = Input.GetAxis("Mouse Y");
        if(myxVal != 0)
        {
            print("x movement: " + myxVal);
            
        }
        if(myyVal != 0)
        {
            print("y movement: " + myyVal);
            
        }

        
    }
}
