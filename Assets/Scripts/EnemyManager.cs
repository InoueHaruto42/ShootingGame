using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    /// <summary>
    /// 敵を生成する間隔
    /// </summary>
    public float generateInterval;

    /// <summary>
    /// 敵のプレハブ
    /// </summary>
    public GameObject enemyPrefab;
    void Start()
    {
        //決まった時間ごとにSpawn()を実行
        InvokeRepeating("Spawn", generateInterval, generateInterval);
    }

    /// <summary>
    /// 敵をランダムな位置に生成
    /// </summary>
    private void Spawn()
    {
        Vector2 randomPos = new Vector2(8f, Random.Range(-4f, 4f));

        Instantiate(enemyPrefab, randomPos, transform.rotation);
    }
}

