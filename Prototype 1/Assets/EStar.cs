using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EStar : MonoBehaviour
{
    Vector3 rotatePoint = Vector3.zero; //回転の中心
    Vector3 rotateAxis = new Vector3(0,0,1); //回転軸
    float speed = 5f;
    int trigger = 0;

    Transform target;

    public int ONOFF_count = 0;

    public int GetONOFF_count()
    {
        return ONOFF_count;
    }

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("star").transform;

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void OnTriggerStay(Collider other)
    {
        string layerName = LayerMask.LayerToName(other.gameObject.layer);

        if (layerName == "En")
        {
            if (Input.GetKey(KeyCode.Space))
            {

                transform.RotateAround(target.position, rotateAxis, speed);
                
            }
        }
    }


}
