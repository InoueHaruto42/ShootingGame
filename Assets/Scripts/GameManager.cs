using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }//シングルトン化

    /// <summary>
    /// 現在のスコア
    /// </summary>
    public int score;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // シーンをまたいで保持したい場合
        }
        else
        {
            Destroy(gameObject); // すでにインスタンスがあれば破棄
        }
    }

    void Start()
    {
        score = 0;//スコアの初期化
    }

    /// <summary>
    /// スコアを増加させる
    /// </summary>
    /// <param name="x">この値だけスコア増加</param>
    public void AddScore(int x)
    {
        score += x;
    }

    /// <summary>
    /// スコアをリセットする
    /// </summary>
    public void ResetScore()
    {
        score = 0;
    }

    /// <summary>
    /// 爆発音を鳴らす
    /// </summary>
    public void Explode()
    {
        GetComponent<AudioSource>().Play();
    }
}

