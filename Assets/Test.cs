using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�L�����N�^�[��\�����鏈��
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
        //���݂̃L�����N�^�[�������E�Ɉړ����鏈��
        Debug.Log("riko watanabe");
    }
}
