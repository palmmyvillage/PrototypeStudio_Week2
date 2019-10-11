using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoving_Ele : MonoBehaviour
{
    public float speed;
    public Sprite[] runningSprite;
    private SpriteRenderer Sprite;
    public int maxTiming;
    private int realTiming;
    private int usingSprite = 1;

    private float xSpeed, zSpeed;
    private Rigidbody player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
        Sprite = GetComponent<SpriteRenderer>();
        realTiming = maxTiming;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        xSpeed = Input.GetAxis("Horizontal") * speed;
        zSpeed = Input.GetAxis("Vertical") * speed;
        
        player.velocity = new Vector3(xSpeed,0,zSpeed);
        
        //for turning
        if (Input.GetAxis("Horizontal") > 0)
            transform.eulerAngles = new Vector3(0,0,0);
        else if (Input.GetAxis("Horizontal") < 0)
            transform.eulerAngles = new Vector3(0,180,0);

        //for Animation
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
            realTiming--;

        if (realTiming <= 0)
        {
            usingSprite *= -1;
            realTiming = maxTiming;
        }

        if (usingSprite == 1)
            Sprite.sprite = runningSprite[0];
        else if (usingSprite == -1)
            Sprite.sprite = runningSprite[1];

    }
}
