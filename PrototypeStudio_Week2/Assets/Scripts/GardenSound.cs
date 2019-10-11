using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GardenSound : MonoBehaviour
{
    public bool ending = false;

    private AudioSource god;
    // Start is called before the first frame update
    void Start()
    {
        god = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ending)
        {
            god.Play(0);
            Debug.Log("playsound");
            ending = false;
        }
    }
}
