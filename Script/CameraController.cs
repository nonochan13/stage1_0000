using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    // 変数を定義する（データを入れる箱を作る）
    public Camera mainCamera;
    public Camera subCamera;

    void Start()
    {

        // ゲーム開始時点では「サブカメラ」を「無効（オフ）」にしておく。
        subCamera.enabled = false;

    }

    void Update()
    {

        // もしも「Fire3」のボタンを「押し続けている間」は
        if (Input.GetButton("Fire2"))
        {

            // メインカメラを「無効（オフ）」にする。
            mainCamera.enabled = false;

            // サブカメラを「有効（オン）」にする。
            subCamera.enabled = true;

        }
        else
        { // そうでない間（Fire3ボタンを離している間）は

            // メインカメラを「有効（オン）」にする。
            mainCamera.enabled = true;

            // サブカメラを「無効（オフ）」にする。
            subCamera.enabled = false;
        }
    }
}