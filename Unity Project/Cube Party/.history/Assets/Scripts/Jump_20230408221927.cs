using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Animator animator;

    [Header("move")]
    [SerializeField] float moveSpeed;
    [Header("jump")]
    [SerializeField] float jumpHeight;
    [SerializeField] float jumpSpeed;
    [SerializeField] float fallSpeed;
    [SerializeField] float jumpTarget;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
        jump();
    }

    void move(){
        transform.rotation = Quaternion.LookRotation(dir);
        animator.SetBool("isRun",true);
        Vector3 distance = moveSpeed *Time.deltaTime * new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(distance);
    }

    void jump(){
        if (Input.GetKeyDown(KeyCode.Space)){
            jumpTarget = jumpHeight;
        }
        if (jumpTarget > 0 ){
            transform.Translate(Vector3.up * jumpSpeed * Time.deltaTime);
            if(transform.position.y >= jumpTarget){
                jumpTarget = 0;
            }
        } else if(transform.position.y > 1){
            transform.Translate(Vector3.down * fallSpeed* Time.deltaTime);
            if(transform.position.y < 1){
                Vector3 newPos = transform.position;
                newPos.y = 1;
                transform.position = newPos;
            }
        }
    }
}
