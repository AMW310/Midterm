using System;
using System.Runtime.InteropServices.ComTypes;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private AttackComponent _attackComponent;
    private MovementComponent _movementComponent;


    void Awake()
    {
        _attackComponent = GetComponent<AttackComponent>();
        _movementComponent = GetComponent<MovementComponent>();
    }

    void Start()
    {
        PlayerController.Init(this);
        PlayerController.GameState();
    }

    public void Attack(bool readValueAsButton) => _attackComponent.Attack(readValueAsButton);

    public void Move(Vector2 readValue) => _movementComponent.Move(readValue);


}
