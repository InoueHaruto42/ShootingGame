using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScoreText : MonoBehaviour
{
    /// <summary>
    /// 最終スコアを表示するテキスト
    /// </summary>
    public TextMeshProUGUI FScoreT;

    void Start()
    {
        FScoreT.text = "FinalSCORE : " + GameManager.Instance.score;
    }
}

