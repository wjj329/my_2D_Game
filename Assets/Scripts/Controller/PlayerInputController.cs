using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    
    public void OnMove(InputValue value) //Input System 사용(Send Messages)
    {
        //Debug.Log(moveInput);
        Vector2 moveInput = value.Get<Vector2>().normalized;
        
        
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value) // 추가 공부
    {

        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = Camera.main.ScreenToViewportPoint(newAim);

        newAim = (worldPos - (Vector2)transform.position).normalized;
        //플레이어에 대한 로컬 마우스 좌표
        CallLookEvent(newAim);
    }





}

