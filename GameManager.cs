using MalbersAnimations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    TimeManager timeManager;
    private bool isGameOver = false;
    [HideInInspector]
    public bool isClear = false;
    private bool isSnow = false;
    public GameObject Snow;
    //public Message message;
    public bool isSpeek = false;
    public GameObject SpeekPanel;
    public Speak speak;
    public MalbersInput malbersInput;

    //Use this for initialization
    void Start () {
        timeManager = GameObject.Find("TimeManager").GetComponent<TimeManager>();
        Snow.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        //
        timeManager.timeText.text = Mathf.RoundToInt((timeManager.timeOver - timeManager.nowTime)).ToString();
        //残り秒後に雪を降らす。秒後にタイムオーバー。
        if (timeManager.nowTime >= timeManager.snow)
        {
            this.isSnow = true;
            Snow.SetActive(true);
        }
        Debug.Log(isGameOver);
		if(timeManager.nowTime >= timeManager.timeOver && isClear==false)
        {
            this.isGameOver = true;
            //　経過時間を表示
            Debug.Log(timeManager.nowTime);

            //　ゲームオーバー時間
            if (timeManager.nowTime >= timeManager.timeOver)
            {
                timeManager.timeOverPanel.SetActive(true);

                //stateTextにTimeOverPanelを表示
                this.timeManager.stateText.GetComponent<Text>().text = "TimeOver";
            }

        }
        else
        {
            //Enterキーを押すと次のtextが流れてくる。
            if (Input.GetKeyDown(KeyCode.Return))
            {
                //if (message.text.Length != message.counter)
                //{
                //    message.nameText.text = this.name;
                //    message.descriptionText.text = message.text[message.counter];
                //    message.counter++;
                //}
                //else
                //{
                //}
            }
        }

        if (isSpeek)
        {
            SpeekPanel.SetActive(true);
            malbersInput.enabled = false;
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (speak.messageList.Count > speak.counter)
                {
                    speak.NextMessage();
                }
                else
                {
                    speak.EndMessage();
                    isSpeek = false;
                }
            }
        }
        else
        {
            SpeekPanel.SetActive(false);
            malbersInput.enabled = true;
        }
    }


}
