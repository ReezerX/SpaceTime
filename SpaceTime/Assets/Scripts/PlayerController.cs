<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


public float moveSpeed = 5f;
public Transform movePoint;

    public LayerMask movementSTOP;

    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {

    	transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
    	//movement
        if(Vector3.Distance(transform.position, movePoint.position) <= .05f) { 
            //lef - right
       if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f){
                if(!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, movementSTOP)) { 
            movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                };
            } 
            //up - down
       else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Vertical"), 0f, 0f), .2f, movementSTOP))
                {
                    movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                };
            };
        };
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


public float moveSpeed = 5f;
public Transform movePoint;

    public LayerMask movementSTOP;

    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {

    	transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
    	//movement
        if(Vector3.Distance(transform.position, movePoint.position) <= .05f) { 
            //lef - right
       if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f){
                if(!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, movementSTOP)) { 
            movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                };
            } 
            //up - down
       else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Vertical"), 0f, 0f), .2f, movementSTOP))
                {
                    movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                };
            };
        };
    }
}
>>>>>>> master
