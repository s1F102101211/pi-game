using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetile : MonoBehaviour

{
private float timer=0;
//SerializeField�����邱�Ƃ�Unity���max time �𒲐��ł���悤��
[SerializeField]private float maxTime=10.0f;
private bool moveFlag=true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //1�t���[�����Ƃ̎��Ԃ�TIme�ɉ��Z
        timer+=Time.deltaTime;
        if(timer>=maxTime)
        {
            timer=0;
            //True�������ꍇ��False����
            //False�������ꍇ��True����
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
