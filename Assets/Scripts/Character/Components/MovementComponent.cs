using System;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class MovementComponent : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private Rigidbody2D rb;
    private Vector2 _moveDirections;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    public void Move(Vector2 readValue)
    {
        _moveDirections = new Vector2(readValue.x, readValue.y);
    }

    void FixedUpdate()
    {
        rb.AddForce(transform.position * _moveDirections * moveSpeed, ForceMode2D.Force);
    }
}
