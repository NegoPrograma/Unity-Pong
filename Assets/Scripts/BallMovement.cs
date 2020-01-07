using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public float speed = 300f, extraSpeed=0.5f, maxSpeed = 500f;
    public float max,min;
    public int hitCounter;
    public Rigidbody2D ball;
    public Vector2 direction;
    public bool playerTurn;
    void Start(){
        //StartCoroutine é uma função que executa uma thread nova, ou seja, ela espera uma função que retorne um IEnumerator 
        ball = gameObject.GetComponent<Rigidbody2D>();
        max = 6.3f;
        min = -5.7f;
        direction = new Vector2(-1,0);
        StartCoroutine(ThreadStart());
    }

    public IEnumerator ThreadStart(){
        this.hitCounter = 0;
        //faz a thread principal do game esperar 2 segundos, para não afetar a velocidade da bola, que é influenciada pelo hitcounter atual
        yield return new WaitForSeconds(2);
        MoveBall(direction);
    }

    void Update(){
                scoreMade(new Vector2(ball.transform.position.x,ball.transform.position.y),max,min);
    }
    void scoreMade(Vector2 ballpos,float max, float min){
        if(ballpos.x >= max){
            playerTurn = true;
            this.ball.transform.position = new Vector2(1,0);
            direction = new Vector2(1,0);
            Player1.score++;    
        } else if(ballpos.x < min){
            playerTurn = false;
            this.ball.transform.position = new Vector2(-1,0);    
            direction = new Vector2(-1,0);
            Player2.score++;
        }
        
    }

    private  void OnCollisionEnter2D(Collision2D collision){
        Rigidbody2D racket = collision.gameObject.GetComponent<Rigidbody2D>();
        if(collision.gameObject.name ==  "Player1" || collision.gameObject.name ==  "Player2"){
            if(ball.transform.position.y < racket.transform.position.y && 
            ball.transform.position.y >= racket.transform.position.y - collision.collider.bounds.size.y/2){
                direction.y = -1;
            } else{
                direction.y = 1;
            }
            direction.x = -direction.x;
            IncreaseRhythm();
        }
        print(hitCounter);
        MoveBall(direction);
    }

    public void MoveBall(Vector2 direction){
        direction = direction.normalized;
        speed = speed + hitCounter*extraSpeed;
        ball.velocity = direction*speed*Time.deltaTime;
    }

   public void IncreaseRhythm(){
            speed+= 10;
            hitCounter++;
   }
    
}
