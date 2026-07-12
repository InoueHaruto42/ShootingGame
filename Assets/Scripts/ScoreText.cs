using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    /// <summary>
    /// スコアを表示するテキスト
    /// </summary>
    public TextMeshProUGUI ScoreT;

    void Update()
    {
        ScoreT.text = "SCORE : " + GameManager.Instance.score;
    }
}

