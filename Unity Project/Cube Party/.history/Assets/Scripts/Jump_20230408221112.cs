using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    [Header("move")];
    [SerializeField] float moveSpeed;
    [Header("jump")];
    
    [SerializeField] float jumpHeight;
    [SerializeField] float jumpSpeed;
    [SerializeField] float fallSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
        jump();
    }

    void move(){
        Vector3 distance = moveSpeed *Time.deltaTime * new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(distance);
    }

    void jump(){
        if (Input.GetKeyDown(KeyCode.Space)){
            jummpTarget = jumpHeight;
        }
        if (jummpTarget > 0 ){
            transform.Translate(Vector3.up * jumpSpeed * Time.deltaTime);
            if(transform.position.y >= jummpTarget){
                jummpTarget = 0;
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
