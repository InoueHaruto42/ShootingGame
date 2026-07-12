using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    /// <summary>
    /// 弾のスピード
    /// </summary>
    public float bulletSpeed = 10f;

    /// <summary>
    /// 爆発エフェクトのプレハブ
    /// </summary>
    public GameObject explosionPrefab;

    void Update()
    {
        BulletMove();
        OffScreen();
    }

    /// <summary>
    /// 弾の動きを管理
    /// </summary>
    private void BulletMove()
    {
        transform.position += new Vector3(bulletSpeed, 0, 0) * Time.deltaTime;
    }

    /// <summary>
    /// 弾が画面外に出たら
    /// </summary>
    private void OffScreen()
    {
        if (this.transform.position.x > 10f)
        {
            Destroy(this.gameObject);
        }

    }

    /// <summary>
    /// 何かとぶつかったら
    /// </summary>
    /// <param name="collision">ぶつかった物体の情報</param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameManager.Instance.Explode();
            Instantiate(explosionPrefab, collision.transform.position, transform.rotation);
            GameManager.Instance.AddScore(1);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }

    }
}

