using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{


    private TopDownCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() // 리지드 바디 등 물리법칙 사용 시 업데이트 대신 fixed에 넣음
    {
        ApplyMovement(_movementDirection);
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;

    }

    private void ApplyMovement(Vector2 direction)
    {
        direction *= 10;

        _rigidbody.velocity = direction; // 속도와 방향을 정해줌
    }

}
