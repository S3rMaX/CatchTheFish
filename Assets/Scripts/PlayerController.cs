using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool IsMoving { get => _isMoving; set => _isMoving = value;}
    private bool _isMoving;
    [SerializeField]
    private float moveSpeed;
    private Transform myTransform;

    private float leftViewportLimit;
    private float rightViewportLimit;

    private float playerOffset = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
        leftViewportLimit = Camera.main.ViewportToWorldPoint(Vector3.zero).x + playerOffset;
        rightViewportLimit = Camera.main.ViewportToWorldPoint(Vector3.right).x - playerOffset;
    }

    // Update is called once per frame
    void Update()
    {
        if (_isMoving)
        {
            SetMovement();
        }

        if (myTransform.position.x > rightViewportLimit)
            SetLimitPlayerPosition(rightViewportLimit);

        if (myTransform.position.x < leftViewportLimit)
            SetLimitPlayerPosition(leftViewportLimit);
    }

    private void SetLimitPlayerPosition(float limit)
    {
        myTransform.position = new Vector3(limit, transform.position.y, 0);
    }

    private void SetMovement()
    {
        float inputX = Input.GetAxis("Horizontal");
        myTransform.position += Vector3.right * (inputX * moveSpeed * Time.deltaTime);
    }
}
