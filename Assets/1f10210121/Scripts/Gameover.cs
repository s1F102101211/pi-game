using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    [SerializeField] private Text Gameover; 

    void Start()
    {

        Gameover.text = "Gameover";
    }
}