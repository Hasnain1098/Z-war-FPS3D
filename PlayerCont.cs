using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCont : MonoBehaviour
{
    private float m_StickToGroundForce;
    public CharacterController playcont;
    public float speed = 10f;
    float movementX, movementY;
    Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()                               
    {


        movementY = m_StickToGroundForce;
         movementX = Input.GetAxis("Horizontal")*speed*Time.deltaTime;
        movementY = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        playcont.Move(transform.forward * movementY);
        playcont.Move(transform.right*movementX);
       
    }
}
