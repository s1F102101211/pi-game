using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //������������(1�b�Ɉ��G������Ă�������)
    public GameObject dog1Prefab;
    float span=5.0f;
    float delta=0;

    // Update is called once per frame
    void Update()
    {
        this.delta+=Time.deltaTime;
        if(this.delta > this.span)
        {
            Debug.Log(this.delta);
            this.delta=0;
            //generator���H��
            //go���Ă����ϐ��ɁAdog1Prefab�i�݌v�}�j�������Ă�������
            GameObject go =Instantiate(dog1Prefab);
            //int px=Random.Range(-6,7);
            go.transform.position=new Vector3(32,15,0);
        }
    }
}
