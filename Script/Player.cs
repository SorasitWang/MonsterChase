using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float moveForce = 10;

    [SerializeField]
    private float jumpForce = 11;

    private Rigidbody2D myBody;
    private Animator anim;
    private string WALK_ANIMATION = "walk";
    private string GROUND_TAG = "Ground";
    private string ENEMY_TAG = "Enemy";
    private SpriteRenderer  sr;
    private UnityEngine.UI.Text score;
    private bool isGrounded = true;
    private float movementX;
    // Start is called before the first frame update
    private void Awake() {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();

    }
    
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard();
        AnimaterPlayer();
       
    }

    private void FixedUpdate() {
         PlayerJump();
    }
    void PlayerMoveKeyboard(){
        movementX = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(movementX,0f,0f) * Time.deltaTime * moveForce;
    }

    void AnimaterPlayer(){
       // Debug.Log(movementX);
        if (movementX < 0){
            sr.flipX = true;
            anim.SetBool(WALK_ANIMATION,true);
        }
        else if (movementX > 0){
            sr.flipX = false;
            anim.SetBool(WALK_ANIMATION,true);
        }
        else {
            anim.SetBool(WALK_ANIMATION,false);
        }

    }

    void PlayerJump(){
        if (Input.GetAxisRaw("Vertical")==1 ){
             Debug.Log("Pressed Jump");
            if (isGrounded ){
                isGrounded = false;
                myBody.AddForce(new Vector2(0f,jumpForce),ForceMode2D.Impulse);
            }
            
        }
    }

  private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag(GROUND_TAG)){
            isGrounded = true;
            Debug.Log("On ground");
        }

        if (other.gameObject.CompareTag(ENEMY_TAG)){
            //Score.plusScore();
            Destroy(gameObject);
        }
    }

    

}
