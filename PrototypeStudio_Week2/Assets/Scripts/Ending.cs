using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public GameObject player;
    public GameObject GardenofGod;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.GetComponent<SpriteRenderer>().sprite = player.GetComponent<CharacterMoving_Final>().runningSprite[0];
            player.GetComponent<CharacterMoving_Final>().enabled = false;
            player.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
            Camera.main.gameObject.GetComponent<CamareMove>().ending = true;
            GardenofGod.GetComponent<GardenSound>().ending = true;
        }
    }

    //-13.1,-7.4,-57.9
}
