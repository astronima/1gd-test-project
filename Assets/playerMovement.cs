using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{

    Rigidbody2D rb;
    [SerializeField] float boostModifier = 2f;
    float jumpAmount = 10;
    Vector2 inputDirection = Vector2.zero;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnMove(InputValue value)
    {
        Vector2 movementDir = value.Get<Vector2>(); // returns a vector 2 containing value
        Debug.Log(movementDir);
       // rb.AddForce(movementDir * boostModifier, ForceMode2D.Impulse);

        inputDirection = movementDir;
        
    }

    private void Update()
    {
        rb.AddForce(inputDirection * boostModifier);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            Debug.Log("jumped");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("meowch");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("meyay!");
    }

}
