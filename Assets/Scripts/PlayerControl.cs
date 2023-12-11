using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public string upKeyToMove;
    public string downKeyToMove;
    public int yDirectionToMove;
    public int ySpeedMovement;
    public float yMinLimitToMove;
    public float yMaxLimitToMove;
    private float yPosition;
    public string playerType;
    void Update()
    {
        if (Input.GetKey(downKeyToMove) == false && Input.GetKey(upKeyToMove) == false)
        {
            yDirectionToMove = 0;
        }
        else if (Input.GetKeyDown(upKeyToMove) == true)
        {
            yDirectionToMove = 1;
        }
        if (Input.GetKeyDown(downKeyToMove) == true)
        {
            yDirectionToMove = -1;
        }
        yPosition = Mathf.Clamp(transform.position.y + ySpeedMovement * yDirectionToMove * Time.deltaTime, yMinLimitToMove, yMaxLimitToMove);
        transform.position = new Vector2(transform.position.x, yPosition);
    }
    void FixedUpdate()
    {

        
    }
}

