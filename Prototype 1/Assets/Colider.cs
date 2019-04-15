using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colider : MonoBehaviour
{
    Vector3 rotatePoint = Vector3.zero; //回転の中心
    Vector3 rotateAxis = Vector3.zero; //回転軸
    float starAngle = 0f;

    int ONOFF_player;
    int ONOFF_enemy;

    public Material[] _material;
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        ONOFF_player = GameObject.Find("star").GetComponent<Exsample>().ONOFF_count;
        ONOFF_enemy = GameObject.Find("star2").GetComponent<EStar>().ONOFF_count;
        i = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //オブジェクトが衝突したとき
    void OnTriggerEnter(Collider other)
    {
        string layerName = LayerMask.LayerToName(other.gameObject.layer);
        
        if (layerName == "EStar")
        {
            GetComponent<Renderer>().material = _material[2];
            if (ONOFF_player < ONOFF_enemy)
            {
                GetComponent<Renderer>().material = _material[1];
            }
        }
    }

    //オブジェクトが離れた時
    void OnTriggerExit(Collider other)
    {
        GetComponent<Renderer>().material = _material[0];
        //GetComponent<Renderer>().material.color = Color.white;

    }

    //オブジェクトが触れている間
    void OnTriggerStay(Collider other)
    {
        string layerName = LayerMask.LayerToName(other.gameObject.layer);

        if (layerName == "EStar")
        {
            GetComponent<Renderer>().material = _material[2];
            if (ONOFF_player < ONOFF_enemy)
            {
                GetComponent<Renderer>().material = _material[1];
            }
        }
    }

    //IEnumerator MoveStar()
    //{

    //    //回転処理
    //    float sumAngle = 0f; //angleの合計を保存
    //    while (sumAngle < 72f)
    //    {
    //        starAngle = 5f; //ここを変えると回転速度が変わる
    //        sumAngle += starAngle;

    //        //72度以上回転しないように制限
    //        if (sumAngle > 72f)
    //        {
    //            starAngle -= sumAngle - 72f;
    //        }
    //        transform.RotateAround(rotatePoint, rotateAxis, starAngle);

    //        yield return null;
    //    }

    //    //回転中のフラッグをfalseに
    //    rotatePoint = Vector3.zero;
    //    rotateAxis = Vector3.zero;
    //    yield break;
    //}
}
