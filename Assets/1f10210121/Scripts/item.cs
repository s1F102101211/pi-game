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
     //�֐��̒�`�͊֐��̒��łł��Ȃ�����update�̂��Ƃł���
    //torigger�ɐG�ꂽ���ɂ�����������֐�
    //�Ώۂ�2�������R���C�_�[�����ĂāA1�ȏナ�W�b�h�{�f�B�����Ă���K�v������
     private void OnTriggerEnter2D(Collider2D other)
    {
        //�T�N�����{���v���C���[�ɐG�ꂽ��
        if (other.gameObject.CompareTag("Player"))
        {
           Destroy(gameObject);
        }
    }
}
