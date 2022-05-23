using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class can1 : MonoBehaviour
{
    // Start is called before the first frame update
    void update(){
        if (Input.GetKey(KeyCode.JoystickButton0))
        {
            gameObject.SetActive(false);
        }      
    }
}
        
