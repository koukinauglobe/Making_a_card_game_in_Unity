using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugChangeCard : MonoBehaviour
{
    CardObject cardobject;
    //CardObjectクラスを参照しますよ。
    int cardIndex = 0;
    //cardIndexの値を宣言

    public GameObject card;
    //外部から参照する予定のcardというオブジェクトの宣言（後にドラッグアンドドロップ）。

    private void Awake()
    {
        cardobject = card.GetComponent<CardObject>();
        //cardにアタッチされているCardObjectを取得して使用します。
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 28), "Hit me!"))
        //Hit me!!と書いてあるボタンを作って押されたら下記を実行
        {
            if (cardIndex >= cardobject.faces.Length)
            //もしfaces配列の長さよりもcardIndexの値が大きくなったら下記を実行
            {
                cardIndex = 0;
                cardobject.ToggleFace(false);//裏面をレンダー
            }
            else
            {
                cardobject.cardindex = cardIndex;//cardIndexの値を代入（最初は０）
                cardobject.ToggleFace(true);//表面をレンダー
                cardIndex++;//cardIndexの値をインクリメント
            }

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
