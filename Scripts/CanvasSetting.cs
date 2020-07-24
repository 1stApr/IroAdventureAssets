using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSetting : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas1;
    void Start()
    {
        canvas1.transform.localScale = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    public void setting()
    {
        canvas1.transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
