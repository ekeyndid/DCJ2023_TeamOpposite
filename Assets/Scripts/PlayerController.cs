using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool smoothTransition = false;
    public float transitionSpeed = 10f;
    public float transitionRotationSpeed = 100f;

    private Vector3 targetGridPos;
    private Vector3 prevTargetGridPos;
    private Vector3 targetRotation;

    [SerializeField] private bool facingWallFront;
    [SerializeField] private bool facingWallBack;
    [SerializeField] private bool facingWallLeft;
    [SerializeField] private bool facingWallRight;

    public LayerMask layer;

    private void Start()
    {
        targetGridPos = Vector3Int.RoundToInt(transform.position);
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        CheckForCollisions();
        MovePlayer();
        RotatePlayer();
    }

    void MovePlayer()
    {
        if (true)
        {
            prevTargetGridPos = targetGridPos;

            Vector3 targetPosition = targetGridPos;

            if (!smoothTransition)
            {
                transform.position = targetPosition;
            }
            else
            {
                transform.position =
                    Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * transitionSpeed);
            }
        }
        else
        {
            targetGridPos = prevTargetGridPos;
        }
    }

    void RotatePlayer()
    {
        if (targetRotation.y > 270f && targetRotation.y < 361f) targetRotation.y = 0f;
        if (targetRotation.y < 0f) targetRotation.y = 270f;
        
        if (!smoothTransition)
        {
            transform.rotation = Quaternion.Euler(targetRotation);
        }
        else
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(targetRotation),
               Time.deltaTime * transitionRotationSpeed);
        }
    }
    
    // Player has raycasts going from each of the cardinal directions to see if it's facing a wall on any of those directions
    // If they are, the appropriate bool is checked and they can't go in that direction
    // Pretty expensive, may cause slowdown but will work for now
    private void CheckForCollisions()
    {
        RaycastHit frontHit;
        RaycastHit backHit;
        RaycastHit leftHit;
        RaycastHit rightHit;

        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out frontHit, 0.8f);
        
        if (frontHit.collider == null)
        {
            facingWallFront = false;
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * frontHit.distance, Color.black);
            Debug.Log("Free to move forward");
        }
        else if (frontHit.collider.CompareTag("Wall"))
        {
            facingWallFront = true;
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * frontHit.distance, Color.yellow);
            Debug.Log("Facing front wall");
        }
        
        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), out backHit, 0.8f);
        
        if (backHit.collider == null)
        {
            facingWallBack = false;
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.back) * backHit.distance, Color.black);
            Debug.Log("Free to move backward");
        }
        else if (backHit.collider.CompareTag("Wall"))
        {
            facingWallBack = true;
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.back) * backHit.distance, Color.yellow);
            Debug.Log("Facing back wall");
        }
        
        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out leftHit, 0.8f);
        
        if (leftHit.collider == null)
        {
            facingWallLeft = false;
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left) * leftHit.distance, Color.black);
            Debug.Log("Free to move left");
        }
        else if (leftHit.collider.CompareTag("Wall"))
        {
            facingWallLeft = true;
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left) * leftHit.distance, Color.yellow);
            Debug.Log("Facing left wall");
        }
        
        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out rightHit, 0.8f);
        
        if (rightHit.collider == null)
        {
            facingWallRight = false;
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * rightHit.distance, Color.black);
            Debug.Log("Free to move right");
        }
        else if (rightHit.collider.CompareTag("Wall"))
        {
            facingWallRight = true;
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * rightHit.distance, Color.yellow);
            Debug.Log("Facing right wall");
        }
    }

    public void RotateLeft() { if (AtRest) targetRotation -= Vector3.up * 90f; }
    public void RotateRight() { if (AtRest) targetRotation += Vector3.up * 90f; }
    
    public void MoveForward() { if (AtRest && !facingWallFront) targetGridPos += transform.forward; }
    public void MoveBackward() { if (AtRest && !facingWallBack) targetGridPos -= transform.forward; }
    public void MoveLeft() { if (AtRest && !facingWallLeft) targetGridPos -= transform.right; }

    public void MoveRight() { if (AtRest && !facingWallRight) targetGridPos += transform.right; }
    public void ShowToolbar() { }




    bool AtRest
    {
        get
        {
            if((Vector3.Distance(transform.position, targetGridPos) < 0.05f) &&
                (Vector3.Distance(transform.eulerAngles, targetRotation) < 0.05f))
            {
                return true;
            }
            else
            {
                return false;   
            }
        }
    }
}
