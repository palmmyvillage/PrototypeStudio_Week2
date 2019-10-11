using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalText : MonoBehaviour
{

    public bool ending = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ending)
            GetComponent<Text>().color += new Color(0,0,0,0.0025f);

        if (GetComponent<Text>().color.a >= 1)
            ending = false;
    }
}
