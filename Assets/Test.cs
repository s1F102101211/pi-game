using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //キャラクターを表示する処理
        int result=0;
        for (int i=1;i<101;i++)
        {
            result+=i;
        }
        Debug.Log(result);
  
        
    }

    // Update is called once per frame
    void Update()
    {
        //現在のキャラクターを少し右に移動する処理
        Debug.Log("riko watanabe");
    }
}
