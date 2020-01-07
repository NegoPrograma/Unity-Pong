using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

    public static int score = 0;
    public float speed = 300;
    public static bool isAlive;
    GameObject ball;
    Vector3 ballPos;
    public Vector2 vectorPos;
    public Rigidbody2D rigid;
    void Start(){
        ball = GameObject.Find("Ball");
        vectorPos = new Vector2();
        rigid = this.gameObject.GetComponent<Rigidbody2D>();
    }

   public void Move(){
        if(Input.GetKeyDown(KeyCode.Q)){
            vectorPos.y = 1;
            //rigid.AddForce(vectorPos*speed);
            rigid.transform.position= new Vector3(6.3f,rigid.transform.position.y+vectorPos.y,0);
        } 
        else if(Input.GetKeyDown(KeyCode.A)){
            vectorPos.y = -1;
            //rigid.AddForce(vectorPos*speed);
            rigid.transform.position= new Vector3(6.3f,rigid.transform.position.y+vectorPos.y,0);
        }
    }
    
    public void VirtualEnemy(){
        ballPos=ball.transform.position;
        if(rigid.transform.position.y > ballPos.y)
             rigid.AddForce(new Vector2(0,-1)*speed);
        else
            rigid.AddForce(new Vector2(0,1)*speed);

    }
    void Update()
    {
        if(isAlive)
            Move();
        else
            VirtualEnemy();            
    }
}
