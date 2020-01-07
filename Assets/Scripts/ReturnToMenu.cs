using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ReturnToMenu : MonoBehaviour
{
    // Start is called before the first frame update
   public void OnButtonPressed(){
        SceneManager.LoadScene("Menu");
        Player2.score = 0;
        Player1.score = 0;
    }
}
