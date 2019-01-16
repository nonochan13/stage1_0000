using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kakashi : MonoBehaviour {
    //追憶の画像
    public Sprite sprite;
    public Image image;
    public int fearlevel;
    public GameObject TuiokuUI;
    public GameObject SpeekPanel;
    public bool isSpeek = false;
    public GameManager gameManager;

    void Awake()
    {
        TuiokuUI = GameObject.Find("TuiokuUI");
    }

        // Use this for initialization
        void Start() {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        SpeekPanel = GameObject.Find("SpeakPanel");
        //SpeekPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
    }
    public void Event()
    {
        Debug.Log("tuioku");
    }
    public void Touch()
    {
        Destroy(this.gameObject);
    }

    public float GetFearRadius(int level)
    {
        switch (level)
        {
            case 1:
                return 25.0f;
                break;
            case 2:
                return 50.0f;
                break;
            case 3:
                return 75.0f;
                break;
            case 4:
                return 100.0f;
                break;
            case 5:
                return 125.0f;
                break;
        }
        return 10.0f;
    }

}
