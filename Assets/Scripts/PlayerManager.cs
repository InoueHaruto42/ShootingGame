using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerManager : MonoBehaviour
{
    /// <summary>
    /// プレイヤーの移動速度
    /// </summary>
    public float moveSpeed = 5f;

    /// <summary>
    /// 弾のプレハブ
    /// </summary>
    public GameObject bulletPrefab;

    /// <summary>
    /// 弾を発射する場所
    /// </summary>
    public GameObject firingPosition;

    void Update()
    {
        Move();
        Shot();
    }


    /// <summary>
    /// プレイヤーの移動
    /// </summary>
    private void Move()
    {
        //矢印キーまたはWASDで操作できる
        float x = Input.GetAxis("Horizontal") * moveSpeed;
        float y = Input.GetAxis("Vertical") * moveSpeed;

        transform.position += new Vector3(x, y, 0) * Time.deltaTime;
    }

    /// <summary>
    /// 弾を発射
    /// </summary>
    private void Shot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<AudioSource>().Play();
            Instantiate(bulletPrefab, firingPosition.transform.position, transform.rotation);
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
            SceneManager.LoadScene("GameOver");
        }

    }
}

