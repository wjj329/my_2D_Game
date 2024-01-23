using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    //public delegate void OnmoveDel(Vector2 direction);
    //public OnmoveDel OnMoveEvent;
    public event Action<Vector2> OnMoveEvent;   // �͸� �븮��, ��ȯ���� ������ Action ������ Func

    //public delegate void OnupDel(Vector2 direction);
    //public OnupDel OnLookEvent;\
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }


}
