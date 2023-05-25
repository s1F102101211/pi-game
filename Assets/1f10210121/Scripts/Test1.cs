using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 

public class Test1 : MonoBehaviour
{
    //Rigidbody2Dを操作するために宣言してる
    private Rigidbody2D rbody2D;
    private float jumpForce = 350f;
    private int jumpCount = 0;

    //スライダーコンポーネントを操作するために定義
    [SerializeField] private Slider slider;
    private int maxHp=100;
    private int hp=50;

    public float speed=3.0f;

    private Animator anime;


    void Start()
    {
        anime=GetComponent<Animator>();
        //ゲームをスタートした一回だけ実行(初期値の設定)
        //sliderのmaxValueにmaxHpを代入
        slider.maxValue=maxHp;
        hp=50;

        slider.value=hp;
        


    //Test1がアタッチ(スクリプトなどのコンポーネントをつけること)しているオブジェクトにアタッチされているコンポーネントを見つけて取得する
    //Rigidbody2Dをつかっていろいろ操作をするためにgetしてる
      rbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()

    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
 
        anime.SetFloat("speed",speed);
            //Vector3は三つのパラメータを入れる
        //今回はtransform.positionに入れるので、(x,y,z)
        //Time.deltaTimeは1フレームの時間
        transform.position+=new Vector3(speed*Time.deltaTime,0,0);
        transform.localScale=new Vector3(2.795f,2.604f,1);
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
        anime.SetFloat("speed",speed);
        //Vector3は三つのパラメータを入れる
        //今回はtransform.positionに入れるので、(x,y,z)
        //Time.deltaTimeは1フレームの時間
        transform.position-=new Vector3(speed*Time.deltaTime,0,0);
        //X軸を-1にすると左に動く
        transform.localScale=new Vector3(-2.795f,2.604f,1);
        }
        else{
            //右と左を押してないときは、Animationで設定したスピードの値を0にした
            //そうするとidle状態に切り替わってくれる
            anime.SetFloat("speed",0);
        }
        if(Input.GetKeyDown(KeyCode.Space)&&this.jumpCount<2){
            Debug.Log(jumpCount);
            //animationを追加
            anime.SetTrigger("jump");
            GetComponent<AudioSource>().Play();
          this.rbody2D.AddForce(transform.up * jumpForce);
          jumpCount++;
        }
        
    }
    //関数の定義は関数の中でできないからupdateのそとでかく
    //OnCollisionEnter2Dはコライダー2Dに触れた時にだけ反応する関数
     private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Floor");
        if (other.gameObject.CompareTag("Floor")||(other.gameObject.CompareTag("movefloor")))
        {
            jumpCount = 0;
        }
        //otherはプレイヤーが触れた相手の情報が入ってくる
        if (other.gameObject.CompareTag("movefloor")){
            //プレイヤー自身のtransformを触れた床のtransformに合わせるために触れた床を親にしてる
            transform.SetParent(other.transform);
        }
    }

    void OnCollisionExit2D(Collision2D col) {
        //otherはプレイヤーが触れた相手の情報が入ってくる(タグが一致しているか)
    if (col.gameObject.CompareTag("movefloor")) {
        //ジャンプするときは親要素のtransformに合わせたくないのでnull値にする
        transform.SetParent(null);
    }}

    //関数の定義は関数の中でできないからupdateのそとでかく
    //toriggerに触れた時にだけ反応する関数
    //対象の2つが両方コライダーがついてて、1つ以上リジッドボディがついている必要がある
     private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("変更前:"+hp);
        //サクランボがプレイヤーに触れたら
        if (other.gameObject.CompareTag("Item"))
        {
           hp+=10;
           //hpの値がvalueに直接入るようにしてるから、バーの位置も変わる
           slider.value=hp;
           Debug.Log("変更後:"+hp);
        }
    }





}