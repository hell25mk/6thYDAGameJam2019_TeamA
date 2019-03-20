using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private Text TimerText;//残りタイム表示用テキスト
    private double countTime;// = 0.00;//カウント用
    private double seconds;//表示用

    // Start is called before the first frame update
    void Start()
    {
        seconds = countTime = 5.02;//初期化
        seconds = countTime+0.02 ;// = 5.02;//初期化
    }

    // Update is called once per frame
    void Update()
    {

        if (seconds >= 0)
        {
            TimerText.text = seconds.ToString("F2");//残りタイム表示
            //countTime += Time.deltaTime;// カウントアップ
            countTime -= Time.deltaTime; // カウントダウン
            seconds = countTime;

            if (seconds <= 0)
            {
                seconds = 0.00;//値がマイナスになるため0.00を入れる
            }
        }
        else
        {
            TimerText.text = seconds.ToString("F2");//残りタイム表示
        }
    }

}
