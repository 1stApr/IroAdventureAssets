using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer renderer; 
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        
    }
    public void hide2UI()
    {
        
        canvas2.transform.localScale = new Vector3(0, 0, 0);
        canvas3.transform.localScale = new Vector3(0, 0, 0);
    }
    public void setRed()
    {
        renderer.color = new Color(1, 0, 0, 1);
        canvas1.transform.localScale = new Vector3(0, 0, 0);
        canvas2.transform.localScale = new Vector3(0, 0, 0);
        canvas3.transform.localScale = new Vector3(0, 0, 0);
        //PlayerController.maxSpeed = 5;
    }
    public void setGreen()
    {
        renderer.color = new Color(0, 1, 1, 1);
        canvas1.transform.localScale = new Vector3(0, 0, 0);
        canvas2.transform.localScale = new Vector3(0, 0, 0);
        canvas3.transform.localScale = new Vector3(0, 0, 0);
    }
    public void setYellow()
    {
        renderer.color = new Color(1, 1, 0, 1);
        canvas1.transform.localScale = new Vector3(0, 0, 0);
        canvas2.transform.localScale = new Vector3(0, 0, 0);
        canvas3.transform.localScale = new Vector3(0, 0, 0);
        // PlayerController.jumpTakeOffSpeed = 5;
    }
}
