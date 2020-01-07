using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SinglePlayer : MonoBehaviour
{

    public void OnButtonPressed(){
        Player2.isAlive =false;
        SceneManager.LoadScene("Game");
    }

}
