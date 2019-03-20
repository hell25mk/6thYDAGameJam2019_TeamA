using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTimer : MonoBehaviour
{
    [SerializeField]
    private Text TimerText;//残りタイム表示用テキスト
    private double countTime;// = 0.00;//カウント用
    private double seconds;//表示用


    GameObject timeval;
    TimeVal tval;

    // Start is called bef ore the first frame update
   
    void Start()
    {
        timeval = GameObject.Find("Tomato");

        tval = timeval.GetComponent<TimeVal>();

        seconds = countTime = tval.TVal+ 0.02;// = 5.02;//初期化

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
                tval.CheckText();//呼び出してtrue(表示)にする
            }
        }
        else
        {
            TimerText.text = seconds.ToString("F2");//残りタイム表示
            
        }
    }

}
