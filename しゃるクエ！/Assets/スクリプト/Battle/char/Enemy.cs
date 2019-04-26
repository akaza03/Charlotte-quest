using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Enemy : MonoBehaviour
{
    public enum STATE
    {
        ST_NON,
        ST_ALIVE,                   //  生きている
        ST_ACT,                     //  行動中
        ST_DAMAGE,                  //  ダメージ
        ST_DEAD,                    //  死亡
        ST_MAX
    }

    public STATE state;
    EnemyStatus status = new EnemyStatus();

    void Start()
    {
        state = STATE.ST_ALIVE;
        status.SetHP(4);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            status.Damage(1);
            Debug.Log(status.GetHP());
            status.SetHP(status.GetHP());
        }
        if(state == STATE.ST_DEAD)
        {
            Destroy(this.gameObject);
        }
    }

    public void Dead()
    {
        SetState(STATE.ST_DEAD);
        //animator.SetTrigger("Dead");
        Destroy(this.gameObject);
    }

    private void SetState(STATE state)
    {
        this.state = state;
    }
}
