﻿using UnityEngine;

[CreateAssetMenu(fileName ="玩家血量",menuName ="HWC/玩家資料")]
public class PlayerDate : ScriptableObject
{
    [Header("血量與最大血量"), Range(200, 3000)]
    public float hp = 200;

    public float hpMax;

    [Header("冷卻時間"), Range(0, 2)]
    public float cd = 0.5f;
    [Header("武器速度"), Range(1000, 5000)]
    public float power = 1000;


}
