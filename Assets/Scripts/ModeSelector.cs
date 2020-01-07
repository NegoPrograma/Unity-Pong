using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelector : MonoBehaviour
{
public static bool mode;

  void Awake ()
     {        
             DontDestroyOnLoad(gameObject);
     }

}
