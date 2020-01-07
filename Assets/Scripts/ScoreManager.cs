using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scorep1,scorep2;

    void Start(){
        scorep1 = GameObject.Find("Player1Score").GetComponent<Text>();
        scorep2 = GameObject.Find("Player2Score").GetComponent<Text>();
    }

    void atualiza(){
        if(Player2.score > 3 || Player1.score > 3){
            SceneManager.LoadScene("GameOver");
            
            }
    }
    void Update()
    {
        atualiza();
        scorep1.text = Player1.score.ToString();
        scorep2.text = Player2.score.ToString();
    }
}
