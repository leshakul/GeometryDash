using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private int _speed;
    [SerializeField] private int _tapForce;
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private bool _isGround = true;

    private Rigidbody2D _rigidbody2D;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent<Block>(out Block block))
        {
            _isGround = true;
        }       
    }

    private void Start()
    {
        transform.position = _startPosition;

        _rigidbody2D = GetComponent<Rigidbody2D>();

        _rigidbody2D.velocity = Vector2.zero;
    }

    private void Update()
    {
        transform.Translate(Vector2.right * _speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space) && _isGround == true)
        {                   
            _rigidbody2D.velocity = new Vector2(0, 0);
            _rigidbody2D.AddForce(Vector2.up * _tapForce, ForceMode2D.Force);           
            _isGround = false;
        }
    }
}
