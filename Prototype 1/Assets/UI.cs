using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Graphic Text;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        var c = Text.color;
        c.a = Mathf.Abs(Mathf.Repeat(Time.time, 2f) - 1f);
        Text.color = c;
    }
}
