using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 

public class Test1 : MonoBehaviour
{
    //Rigidbody2D�𑀍삷�邽�߂ɐ錾���Ă�
    private Rigidbody2D rbody2D;
    private float jumpForce = 350f;
    private int jumpCount = 0;

    //�X���C�_�[�R���|�[�l���g�𑀍삷�邽�߂ɒ�`
    [SerializeField] private Slider slider;
    private int maxHp=100;
    private int hp=50;

    public float speed=3.0f;

    private Animator anime;


    void Start()
    {
        anime=GetComponent<Animator>();
        //�Q�[�����X�^�[�g������񂾂����s(�����l�̐ݒ�)
        //slider��maxValue��maxHp����
        slider.maxValue=maxHp;
        hp=50;

        slider.value=hp;
        


    //Test1���A�^�b�`(�X�N���v�g�Ȃǂ̃R���|�[�l���g�����邱��)���Ă���I�u�W�F�N�g�ɃA�^�b�`����Ă���R���|�[�l���g�������Ď擾����
    //Rigidbody2D�������Ă��낢�둀������邽�߂�get���Ă�
      rbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()

    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
 
        anime.SetFloat("speed",speed);
            //Vector3�͎O�̃p�����[�^������
        //�����transform.position�ɓ����̂ŁA(x,y,z)
        //Time.deltaTime��1�t���[���̎���
        transform.position+=new Vector3(speed*Time.deltaTime,0,0);
        transform.localScale=new Vector3(2.795f,2.604f,1);
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
        anime.SetFloat("speed",speed);
        //Vector3�͎O�̃p�����[�^������
        //�����transform.position�ɓ����̂ŁA(x,y,z)
        //Time.deltaTime��1�t���[���̎���
        transform.position-=new Vector3(speed*Time.deltaTime,0,0);
        //X����-1�ɂ���ƍ��ɓ���
        transform.localScale=new Vector3(-2.795f,2.604f,1);
        }
        else{
            //�E�ƍ��������ĂȂ��Ƃ��́AAnimation�Őݒ肵���X�s�[�h�̒l��0�ɂ���
            //���������idle��Ԃɐ؂�ւ���Ă����
            anime.SetFloat("speed",0);
        }
        if(Input.GetKeyDown(KeyCode.Space)&&this.jumpCount<2){
            Debug.Log(jumpCount);
            //animation��ǉ�
            anime.SetTrigger("jump");
            GetComponent<AudioSource>().Play();
          this.rbody2D.AddForce(transform.up * jumpForce);
          jumpCount++;
        }
        
    }
    //�֐��̒�`�͊֐��̒��łł��Ȃ�����update�̂��Ƃł���
    //OnCollisionEnter2D�̓R���C�_�[2D�ɐG�ꂽ���ɂ�����������֐�
     private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Floor");
        if (other.gameObject.CompareTag("Floor")||(other.gameObject.CompareTag("movefloor")))
        {
            jumpCount = 0;
        }
        //other�̓v���C���[���G�ꂽ����̏�񂪓����Ă���
        if (other.gameObject.CompareTag("movefloor")){
            //�v���C���[���g��transform��G�ꂽ����transform�ɍ��킹�邽�߂ɐG�ꂽ����e�ɂ��Ă�
            transform.SetParent(other.transform);
        }
    }

    void OnCollisionExit2D(Collision2D col) {
        //other�̓v���C���[���G�ꂽ����̏�񂪓����Ă���(�^�O����v���Ă��邩)
    if (col.gameObject.CompareTag("movefloor")) {
        //�W�����v����Ƃ��͐e�v�f��transform�ɍ��킹�����Ȃ��̂�null�l�ɂ���
        transform.SetParent(null);
    }}

    //�֐��̒�`�͊֐��̒��łł��Ȃ�����update�̂��Ƃł���
    //torigger�ɐG�ꂽ���ɂ�����������֐�
    //�Ώۂ�2�������R���C�_�[�����ĂāA1�ȏナ�W�b�h�{�f�B�����Ă���K�v������
     private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("�ύX�O:"+hp);
        //�T�N�����{���v���C���[�ɐG�ꂽ��
        if (other.gameObject.CompareTag("Item"))
        {
           hp+=10;
           //hp�̒l��value�ɒ��ړ���悤�ɂ��Ă邩��A�o�[�̈ʒu���ς��
           slider.value=hp;
           Debug.Log("�ύX��:"+hp);
        }
    }





}