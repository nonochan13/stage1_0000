using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Message
{
    public string text;
    public string name;
}

public class Speak : MonoBehaviour
{

    // Use this for initialization
    public List<Message> messageList = new List<Message>();
    public Text nameText;
    public Text descriptionText;

    public int counter = 0;
    GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextMessage()
    {
        nameText.text = messageList[counter].name;
        descriptionText.text = messageList[counter].text;
        counter++;
    }

    public void EndMessage()
    {
        counter = 0;
        gameManager.isSpeek = false;
    }

    private void OnMouseDown()
    {
        BiginSpeak();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //BiginSpeak();
            gameManager.isSpeek = true;
            gameManager.speak = this;

            NextMessage();

        }
    }
    void OnTriggerStay(Collider other)
    {
        //プレイヤーtag のオブジェクトが接触したら
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("atari");
        }
    }
    //メッセージを再表示させない
    //private void OnTriggerExit(Collider other)
    //{
    //   gameManager.isSpeek = false;
    //}

    public void BiginSpeak()
    {
        gameManager.isSpeek = true;
        gameManager.speak = this;
        NextMessage();
    }
}
