using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //¶¬‚³‚ê‚éŠúŠÔ(1•b‚Éˆê‰ñ“G‚ğì‚Á‚Ä‚­‚¾‚³‚¢)
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
            //generator‚ªHê
            //go‚Á‚Ä‚¢‚¤•Ï”‚ÉAdog1PrefabiİŒv}j‚ğ‚Â‚­‚Á‚Ä‚­‚¾‚³‚¢
            GameObject go =Instantiate(dog1Prefab);
            //int px=Random.Range(-6,7);
            go.transform.position=new Vector3(32,15,0);
        }
    }
}
