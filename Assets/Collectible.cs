using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Hit");
        Destroy(gameObject); // if using 'this' instead of gameObj, 'this' refers to current script, obj remains but deletes this script
    }

    // OnTriggerStay2D, OnTriggerEnter2D, OnTriggerExit2D
}
