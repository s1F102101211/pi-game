using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetile : MonoBehaviour

{
private float timer=0;
//SerializeFieldをつけることでUnity上にmax time を調整できるように
[SerializeField]private float maxTime=10.0f;
private bool moveFlag=true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //1フレームごとの時間をTImeに加算
        timer+=Time.deltaTime;
        if(timer>=maxTime)
        {
            timer=0;
            //Trueだった場合はFalseを代入
            //Falseだった場合はTrueを代入
            moveFlag=!moveFlag;
        }
        if(moveFlag)
        {
            transform.position+=new Vector3(1*Time.deltaTime,0,0);
        }
        else{
            transform.position-=new Vector3(1*Time.deltaTime,0,0);
        }
    }
}
