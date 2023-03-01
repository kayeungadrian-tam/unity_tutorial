using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    // Public variables
    public Rigidbody2D  myBody;
    public float flapStrength;
    public Logic logic;
    public bool alive = true;

    public Animator anim;

    // Private variables
    private float vBound = 15;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        jump();
        checkVertialBound();
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe")){
            logic.gameOver();
            alive = false;
        };
    }


    private void jump(){
        if (Input.GetKeyDown(KeyCode.Space) && alive){
            anim.ResetTrigger("animTrigger");
            anim.SetTrigger("animTrigger");
            myBody.velocity = Vector2.up * flapStrength;

        }
    }

    private void checkVertialBound(){
        if (Mathf.Abs(transform.position.y) > vBound){
            logic.gameOver();
            alive = false;
        };
    }
}
