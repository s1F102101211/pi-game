using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetile : MonoBehaviour

{
private float timer=0;
//SerializeField‚ğ‚Â‚¯‚é‚±‚Æ‚ÅUnityã‚Émax time ‚ğ’²®‚Å‚«‚é‚æ‚¤‚É
[SerializeField]private float maxTime=10.0f;
private bool moveFlag=true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //1ƒtƒŒ[ƒ€‚²‚Æ‚ÌŠÔ‚ğTIme‚É‰ÁZ
        timer+=Time.deltaTime;
        if(timer>=maxTime)
        {
            timer=0;
            //True‚¾‚Á‚½ê‡‚ÍFalse‚ğ‘ã“ü
            //False‚¾‚Á‚½ê‡‚ÍTrue‚ğ‘ã“ü
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
