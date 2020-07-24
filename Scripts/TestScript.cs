using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour 
{
  
    public float moveSpeed, getBackSpeed;

    bool rightPressed, leftPressed, jumpPressed;
    public static float inputValue;
    public static int jump = 0;


    public void RightButton_Down()
    {
        rightPressed = true;
    }

    public void RightButton_Up()
    {
        rightPressed = false;
    }

    public void LeftButton_Down()
    {
        leftPressed = true;
    }

    public void LeftButton_Up()
    {
        leftPressed = false;
    }

    public void JumpButon_Up()
    {
        jumpPressed = false;
        jump = 0;
    }

    public void JumpButon_Down()
    {
        jumpPressed = true;
        jump = 1;
    }

    void Update()
    {
        bool noInput = false;

        // detecting the direction which value shoud be going
        int dir = 0;
        if (rightPressed && leftPressed) // both directions
            dir = 0;
        else if (rightPressed) // only right
            dir = 1;
        else if (leftPressed) // only left
            dir = -1;
        else // no input at all. force must be lerp into zero
            noInput = true;


        if (noInput)
        {
            // lerping force into zero if the force is greater than a threshold (0.01)
            if (Mathf.Abs(inputValue) >= 0.01f)
            {
                int opositeDir = (inputValue > 0) ? -1 : 1;
                inputValue += Time.deltaTime * getBackSpeed * opositeDir;
            }
            else
                inputValue = 0;
        }
        else
        {
            // increase force towards desired direction
            inputValue += Time.deltaTime * dir * moveSpeed;
            inputValue = Mathf.Clamp(inputValue, -1, 1);
        }

        
    }
	
}
