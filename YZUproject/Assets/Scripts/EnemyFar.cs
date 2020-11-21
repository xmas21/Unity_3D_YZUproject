﻿using UnityEngine;
using System.Collections;

public class EnemyFar : Enemy
{
    [Header("子彈")]
    public GameObject bullet;

    /// <summary>
    /// 攻擊
    /// </summary>
    protected override void Attack()
    {
        base.Attack();
        StartCoroutine(CreateBullet());
    }

    /// <summary>
    /// 射子彈
    /// </summary>
    /// <returns></returns>
    private IEnumerator CreateBullet()
    {
        yield return new WaitForSeconds(data.NearAttackDelay);

        Vector3 pos = transform.position + new Vector3(0, data.NearAttackPos.y, 0);

        pos += transform.forward * data.NearAttackPos.z;

        GameObject temp = Instantiate(bullet, pos, transform.rotation);

        temp.GetComponent<Rigidbody>().AddForce(transform.forward * data.farPower);

        temp.AddComponent<Bullet>();
        temp.GetComponent<Bullet>().damage = data.attack;
        temp.GetComponent<Bullet>().playerBullet = false;

    }
}
