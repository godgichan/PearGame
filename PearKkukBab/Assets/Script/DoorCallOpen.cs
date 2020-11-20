using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCallOpen : MonoBehaviour
{
    private bool _isInsideTrigger = false;


    
    //public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject TheDoor;
    public AudioSource CreakSound;
    
    public GameObject ExtraCross;
    

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _isInsideTrigger = true;
            ExtraCross.SetActive(true);
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            _isInsideTrigger = false;
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
            ExtraCross.SetActive(false);
        }
    }

    


    // Update is called once per frame
    void Update()
    {
        if(_isInsideTrigger)
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                CreakSound.Play();
                TheDoor.GetComponent<Animation>().Play("FirstRoomOutDoor");
            }
        }
        //TheDistance = PlayerCasting.DistanceFromTarget;
    }

    // void OnMouseOver () {
    //     if(TheDistance <= 3) {
    //         ExtraCross.SetActive(true);
    //         ActionDisplay.SetActive(true);
    //         ActionText.SetActive(true);
    //     }
    //     if (Input.GetButtonDown("Action")) {
    //         if(TheDistance <=3) {
    //             this.GetComponent<BoxCollider>().enabled = false;
    //             ActionDisplay.SetActive(false);
    //             ActionText.SetActive(false);
    //             CreakSound.Play();
    //             TheDoor.GetComponent<Animation>().Play("FirstRoomOutDoor");
                
    //         }
    //     }
    // }

    // void OnMouseExit() {
    //     ExtraCross.SetActive(false);
    //     ActionDisplay.SetActive(false);
    //     ActionText.SetActive(false);
    // }
}
