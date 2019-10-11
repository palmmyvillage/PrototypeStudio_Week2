using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamareMove : MonoBehaviour
{
    public bool ending = false;
    private int time = 900;

    public GameObject text;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ending)
        {
            transform.position += new Vector3((-13.2f / 900), (-7.4f / 900), (-47.9f / 900));
            time--;
            
            if (time <= 0)
            {
                text.GetComponent<FinalText>().ending = true;
                ending = false;
                
            }
        }

 
            
    }
}
