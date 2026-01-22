using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GoalManager : MonoBehaviour
{
    public GameObject player;    //プレイヤーを格納するための変数
    public GameObject text;    　//テキストを格納するための変数
    private bool isGoal = false;    //Goalしたかどうか判定する
    public Scene loadNextScene;     // 次のシーン(ステージ)名 
    public Scene loadResetScene;    // 全クリしたら一面に戻る
    public bool blast;              // ゲーム自体をクリアしたか判定

    void Update()
    {
        //Goalした後で画面をクリックされたとき
        if (isGoal && Input.GetMouseButton(0))
        {
            Clear();    // 次のステージへ
        }
    }

    //当たり判定関数
    private void OnTriggerEnter(Collider other)
    {
        //当たってきたオブジェクトの名前がプレイヤーの名前と同じとき
        if (other.name == player.name)
        {
            //テキストの内容を変更する
            text.SetActive(true);      //テキストをオンにして非表示→表示にする
            isGoal = true;            //Goal判定をTrueにする
        }
    }

    private void Clear()
    {
        SceneManager.LoadScene(loadNextScene.name);
    }



}