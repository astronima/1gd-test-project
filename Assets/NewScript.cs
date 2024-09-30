using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool isWounded = false;
        bool isBruised = false;
        if (isBruised && isWounded)
        {
            Debug.Log("A");
        }
        else if (isWounded && !isBruised)
        {
            Debug.Log("B");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
