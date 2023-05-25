using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
     //関数の定義は関数の中でできないからupdateのそとでかく
    //toriggerに触れた時にだけ反応する関数
    //対象の2つが両方コライダーがついてて、1つ以上リジッドボディがついている必要がある
     private void OnTriggerEnter2D(Collider2D other)
    {
        //サクランボがプレイヤーに触れたら
        if (other.gameObject.CompareTag("Player"))
        {
           Destroy(gameObject);
        }
    }
}
