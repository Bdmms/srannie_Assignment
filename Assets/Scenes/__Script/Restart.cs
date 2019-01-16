using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    private Vector3 startingPosition = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
            gameObject.transform.position = startingPosition;
    }
}
