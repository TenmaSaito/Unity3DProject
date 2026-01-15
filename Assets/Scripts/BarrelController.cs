using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelController : MonoBehaviour
{
    public GameObject barrel;       // オブジェクト
    public GameObject box;          // 出現させるもの
    public float maxZ = -325;       // 奥行限界
    public float freezePosY = 0.0f; // 静止させたい高さ

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(barrel.GetComponent<Transform>().position.z >= maxZ)
        {
            Vector3 pos = barrel.GetComponent<Transform>().position;
            pos.z = maxZ;
            transform.position = pos;
        }

        // オブジェクトの高度を取得
        float PosY = barrel.GetComponent<Transform>().position.y;
        if(PosY <= freezePosY)
        { // オブジェクトの高度がfreezePosY以下なら
            box.SetActive(true);        // 当たり判定を代わりに受け持つブロックを出現させる。
            Debug.Log("Activate!");
        }
    }
}
