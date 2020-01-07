using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{

    public static int score = 0;
    public float speed = 30;
    public Vector2 vectorPos = new Vector2();
    public Rigidbody2D rigid;
    void Start(){
        vectorPos.x = 0;
        rigid = this.gameObject.GetComponent<Rigidbody2D>();
    }

    public void Move(){
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            vectorPos.y = 1;
            //rigid.AddForce(vectorPos*speed);
            rigid.transform.position= new Vector3(-5.7f,rigid.transform.position.y+vectorPos.y,0);
        } 
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            vectorPos.y = -1;
            //rigid.AddForce(vectorPos*speed);
            rigid.transform.position= new Vector3(-5.7f,rigid.transform.position.y+vectorPos.y,0);
        }
    }

    void Update()
    {
            Move();
    }
}
