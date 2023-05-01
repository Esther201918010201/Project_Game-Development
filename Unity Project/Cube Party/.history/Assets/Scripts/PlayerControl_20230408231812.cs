using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Animator animator;

    [Header("move")]
    [SerializeField] float moveSpeed;
    [Header("jump")]
    [SerializeField] float jumpSpeed;
    [SerializeField] float fallSpeed;

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
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(horizontal, 0, vertical);
        if (dir != Vector3.zero){
            transform.rotation = Quaternion.LookRotation(dir);
            animator.SetBool("isRun",true);
            transform.Translate(Vector3.forward* moveSpeed *Time.deltaTime);
        }else
        {
            animator.SetBool("isRun",false);
        }
    }

    void jump(){
        if (Input.GetKey(KeyCode.Space)){
            transform.Translate(Vector3.forward* moveSpeed *Time.deltaTime);
            transform.Translate(Vector3.up * jumpSpeed * Time.deltaTime);
            transform.Translate(Vector3.down * fallSpeed* Time.deltaTime);
        }
    }
}
