using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5;
    private Rigidbody2D _myrigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _myrigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       Playermovement();
       FlipSprite(); 
    }

    void FlipSprite()
    {
        bool ploayerHasHorizontalSpeed = Mathf.Abs(_myrigidbody.velocity.x) > Mathf.Epsilon;
        
        if (ploayerHasHorizontalSpeed)
        {
            transform.localScale = new Vector2(Mathf.Sign(_myrigidbody.velocity.x), 1f);
        }
    }

    void Playermovement()
    {
         float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

         FlipSprite();
        _myrigidbody.velocity = new Vector2(horizontalInput * Speed, verticalInput * Speed);
    }
}
