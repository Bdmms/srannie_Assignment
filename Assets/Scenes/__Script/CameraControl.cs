using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private Vector3 firstPosition = new Vector3(0, 0, -10);
    private Vector3 secondPosition = new Vector3(1, 15, 3.5f);
    private Vector3 firstRotation = new Vector3(10, 0, 0);
    private Vector3 secondRotation = new Vector3(90, 0, 0);

    private bool positionSwitch = false;
    private bool registerKey = false;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = firstPosition;
        transform.eulerAngles = firstRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C) && registerKey)
        {
            if (positionSwitch){
                gameObject.transform.position = firstPosition;
                transform.eulerAngles = firstRotation;
            }
            else { 
                gameObject.transform.position = secondPosition;
                transform.eulerAngles = secondRotation;
            }

            positionSwitch = !positionSwitch;
            registerKey = false;
        }
        else if(!Input.GetKey(KeyCode.C))
        {
            registerKey = true;
        }
    }
}
