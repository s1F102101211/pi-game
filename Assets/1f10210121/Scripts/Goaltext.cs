using UnityEngine;
using UnityEngine.UI;

public class GoalDisplay : MonoBehaviour
{
    //public�ɂ���Ƒ��̃t�@�C�����珑���������Ă��܂�
    //SerializeField�́Apprivarte�ł����Ă��AUnity�ォ�����ł���
    [SerializeField] private Text goalText; // Text�R���|�[�l���g������UI�e�L�X�g�I�u�W�F�N�g

    void Start()
    {
        // �V�[������goalText�I�u�W�F�N�g���擾
        //�q�G�����L�[�ɑ��݂��Ă���Object���ׂĂɌ����������Ă���
        //SerializeField�Œ���
        //goalText = GameObject.Find("Goaltext").GetComponent<Text>();
        
        // Goal�̕\����ݒ�
        goalText.text = "Goal";
    }
}