﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    private int LV;             //  レベル
    private int HP;             //  体力
    private int SP;             //  技の発動に必要
    private int ATK;            //  物理攻撃力
    private int DEF;            //  物理防御力
    private int SPD;            //  素早さ
    private int MAT;            //  魔法攻撃力
    private int MDF;            //  魔法防御力
    private int LUK;            //  幸運値

    public void SetHP(int hp)
    {
        this.HP = hp;
    }

    public int GetHP()
    {
        return HP;
    }

    public void SetSP(int sp)
    {
        this.SP = sp;
    }

    public int GetSP()
    {
        return SP;
    }

    public void SetATK(int atk)
    {
        this.ATK = atk;
    }

    public int GetATK()
    {
        return ATK;
    }

    public void SetDEF(int def)
    {
        this.DEF = def;
    }

    public int GetDEF()
    {
        return DEF;
    }

    public void SetSPD(int spd)
    {
        this.SPD = spd;
    }

    public int GetSPD()
    {
        return SPD;
    }

    public void SetMAT(int mat)
    {
        this.MAT = mat;
    }

    public int GetMAT()
    {
        return MAT;
    }

    public void SetMDF(int mdf)
    {
        this.MDF = mdf;
    }

    public int GetMDF()
    {
        return MDF;
    }

    public void SetLUK(int luk)
    {
        this.LUK = luk;
    }

    public int GetLUK()
    {
        return LUK;
    }
}