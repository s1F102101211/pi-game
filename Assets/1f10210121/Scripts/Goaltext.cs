using UnityEngine;
using UnityEngine.UI;

public class GoalDisplay : MonoBehaviour
{
    //publicにすると他のファイルから書き換えられてしまう
    //SerializeFieldは、pprivarteであっても、Unity上から代入できる
    [SerializeField] private Text goalText; // Textコンポーネントを持つUIテキストオブジェクト

    void Start()
    {
        // シーン内のgoalTextオブジェクトを取得
        //ヒエラルキーに存在しているObjectすべてに検索をかけている
        //SerializeFieldで直接
        //goalText = GameObject.Find("Goaltext").GetComponent<Text>();
        
        // Goalの表示を設定
        goalText.text = "Goal";
    }
}