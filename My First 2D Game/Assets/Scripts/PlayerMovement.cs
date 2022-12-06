using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody2D _myrigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _myrigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);
    }

    void FlipSprite()
    {
        
    }
}
