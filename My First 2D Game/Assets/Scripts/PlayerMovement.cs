using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5;
    public GameObject projectilePrefab;
    private Rigidbody2D _myrigidbody;
    private Animator _myanim;
    private GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        _myrigidbody = GetComponent<Rigidbody2D>();
        _myanim = GetComponent<Animator>();
         _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
       Playermovement();
       FlipSprite(); 

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 SpawnPos = new Vector2(transform.position.x + 0f, transform.position.y + 0f);
             Instantiate(projectilePrefab, SpawnPos, projectilePrefab.transform.rotation);
        }
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

        private void OnTriggerEnter2D(Collider2D other)
    {
       if(other.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
            _gameManager.Gameover();
        }
    }

}
