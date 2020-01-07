using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultiPlayer : MonoBehaviour
{
  public void OnButtonPressed(){
        Player2.isAlive =true;
        SceneManager.LoadScene("Game");
    }

}
