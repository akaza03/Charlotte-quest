using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour
{
    //　敵のHP
    [SerializeField]
    private int hp = 3;
    //　敵の攻撃力
    [SerializeField]
    private int attackPower = 1;
    //private Enemy enemy;

    void Start()
    {
        //enemy = GetComponent<Enemy>();
    }

    public void SetHp(int hp)
    {
        this.hp = hp;

        if (hp <= 0)
        {
            //enemy.Dead();
        }
    }

    public int GetHp()
    {
        return hp;
    }
}
