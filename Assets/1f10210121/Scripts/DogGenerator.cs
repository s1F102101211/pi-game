using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //生成される期間(1秒に一回敵を作ってください)
    public GameObject dog1Prefab;
    float span=1.0f;
    float delta=0;

    // Update is called once per frame
    void Update()
    {
        this.delta+=Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta=0;
            //generatorが工場
            //goっていう変数に、dog1Prefab（設計図）をつくってください
            GameObject go =Instantiate(dog1Prefab);
            //int px=Random.Range(-6,7);
            go.transform.position=new Vector3(32,15,0);
        }
    }
}
