using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    
    public void OnMove(InputValue value) //Input System ���(Send Messages)
    {
        //Debug.Log(moveInput);
        Vector2 moveInput = value.Get<Vector2>().normalized;
        
        
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value) // �߰� ����
    {

        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = Camera.main.ScreenToViewportPoint(newAim);

        newAim = (worldPos - (Vector2)transform.position).normalized;
        //�÷��̾ ���� ���� ���콺 ��ǥ
        CallLookEvent(newAim);
    }





}

