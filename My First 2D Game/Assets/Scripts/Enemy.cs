using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Speed = 1;
    private Rigidbody2D _enemyRb;
    private GameObject _player;
    public Rigidbody2D _myrigidbody;
    public int PointValue = 1;

    private GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        _enemyRb = GetComponent<Rigidbody2D>();
        _player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 lookDirection = (_player.transform.position - transform.position).normalized;

        _enemyRb.AddForce(lookDirection * Speed);

        FlipSprite();
    }

    void FlipSprite()
    {
        bool enemyHasHorizontalSpeed = Mathf.Abs(_myrigidbody.velocity.x) > Mathf.Epsilon;
        
        if (enemyHasHorizontalSpeed)
        {
            transform.localScale = new Vector2(Mathf.Sign(_myrigidbody.velocity.x), 1f);
        }
    }

    public void Gameover()
    {

    }
     private void OnEnemyDeath()
    {
        Debug.Log("Was Hit " + gameObject.name);
        _gameManager.UpdateScore(PointValue);
        Destroy(this.gameObject);
    }

    }
