using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    [HideInInspector]
    public int speed;
    private Rigidbody2D myBody;
    void Start()
    {
        
    }

    void Awake() {
            myBody = GetComponent<Rigidbody2D>();
            speed = 7;
    }
    // Update is called once per frame
    void Update()
    {
        myBody.velocity = new Vector2(speed,myBody.velocity.y);
    }
}
