using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimeManager : MonoBehaviour
{
    //　経過時間
    public float nowTime;
    //ステージを終了時に表示するテキスト
    public GameObject stateText;
    public Text timeText;
    //ステージ終了の判定
    private bool isEnd = false;
    //TimeOverPanelUIを宣言
    public GameObject timeOverPanel;
    //もともと20でした
    public float timeOver;
    //雪が降る時間設定
    public float snow;


    void Start()
    {
    }

    void Update()
    {

        //　Time.deltaTimeを足す
        nowTime += Time.deltaTime;


    }
    //Buttonボタンをクリックした時
    public void OnStageButtonClicked(int Button)
    {
        switch (Button)
        {
            case 2:
                //もう一度やり直す
                SceneManager.LoadScene(0);
                break;
            case 0:
                //ゲーム終了
                Application.Quit();
                break;
        }
    }
}
