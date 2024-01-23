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

    private void FixedUpdate() // ������ �ٵ� �� ������Ģ ��� �� ������Ʈ ��� fixed�� ����
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

        _rigidbody.velocity = direction; // �ӵ��� ������ ������
    }

}
