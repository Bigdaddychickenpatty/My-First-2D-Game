using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5;
    private Rigidbody2D _myrigidbody;
    private Animator _myanim;

    // Start is called before the first frame update
    void Start()
    {
        _myrigidbody = GetComponent<Rigidbody2D>();
        _myanim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       Playermovement();
       FlipSprite(); 
    }

    void FlipSprite()
    {
        bool playerHasHorizontalSpeed = Mathf.Abs(_myrigidbody.velocity.x) > Mathf.Epsilon;
        
        if (playerHasHorizontalSpeed)
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

         bool playerHasHorizontalSpeed = Mathf.Abs(_myrigidbody.velocity.x) > Mathf.Epsilon;

         bool playerHasVerticalSpeed = Mathf.Abs(_myrigidbody.velocity.x) > Mathf.Epsilon;

        if(playerHasHorizontalSpeed || playerHasVerticalSpeed)
        {
            _myanim.SetBool("Is Moving", true);
        }
        else
        {
            _myanim.SetBool("Is Moving", false);
        }
    }
}
