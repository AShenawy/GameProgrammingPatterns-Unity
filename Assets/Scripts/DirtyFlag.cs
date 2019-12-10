using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtyFlag : MonoBehaviour
{
    private Transform parentObjectTransform;
    public Transform childTransform;
    private bool isChanged = false;

    // Start is called before the first frame update
    void Start()
    {
        parentObjectTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            parentObjectTransform.position = new Vector2(parentObjectTransform.position.x, (parentObjectTransform.position.y)+8f);
            SetTheflag();
            Debug.Log("Parent object has moved");

            clearTheFlag();
        }
    }

    private void clearTheFlag()
    {
        childTransform.transform.parent = parentObjectTransform;
        Debug.Log("Child position has been updated");
        isChanged = false;
    }

    private void SetTheflag()
    {
        isChanged = true; 
    }
}
