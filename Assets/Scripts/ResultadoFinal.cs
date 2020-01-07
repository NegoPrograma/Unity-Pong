using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResultadoFinal : MonoBehaviour
{

    public Text gameOverText;
    void Start()
    {
        gameOverText = GameObject.Find("Resultado").GetComponent<Text>();
        gameOver();
    }

    void gameOver(){
        if(Player1.score > 3)
            gameOverText.text = "Parabéns campeão! Muito bom, muito bom mesmo.";
        else if(Player2.score > 3 && !Player2.isAlive)            
            gameOverText.text = "Perdeu pra um if/else ta de sacanagemkkkkkkkkkkkk";
        else if(Player2.score > 3){
            gameOverText.text = "Parabéns player 2, n é atoa que playstation 2 é o melhor video game.";
        }            
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
