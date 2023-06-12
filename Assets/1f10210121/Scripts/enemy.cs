using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class enemy : MonoBehaviour
{
    public GameObject dog1Prefab;
    private Animator anime;
    float speed=3.0f;
    private Rigidbody2D rbody2D;
    // Start is called before the first frame update
    void Start()
    {
        anime=GetComponent<Animator>();

      rbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        anime.SetFloat("speed",speed);
        transform.position-=new Vector3(speed*Time.deltaTime,0,0);
        transform.localScale=new Vector3(2.795f,2.604f,1);
    }


    

}
