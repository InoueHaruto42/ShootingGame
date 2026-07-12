using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed;
    void Update()
    {
        Move();
    }

    /// <summary>
    /// 敵の移動
    /// </summary>
    private void Move()
    {
        transform.position += new Vector3(-moveSpeed, 0, 0) * Time.deltaTime;
    }
}

