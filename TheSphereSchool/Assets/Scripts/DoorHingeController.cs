/* Ida Veastad Strand
 * 
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHingeController : MonoBehaviour
{

    /*
     * Opens and closes a door on a hinge
     */

    public Animator doorHinge = null;
    public bool hasKey = false;
    public bool isDoorOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        doorHinge = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isDoorOpen == false)
        {
            if (doorHinge && hasKey)
            {

                Debug.Log("door open");
                doorHinge.SetTrigger("hingeOpenPARA");
                isDoorOpen = true;
            }
            else if (doorHinge == null)
            {
                Debug.Log("no door!");

            }
            else if(!hasKey)
            {

                Debug.Log("no key!");
            }

        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (doorHinge &&isDoorOpen)
            {
                Debug.Log("door close");
                doorHinge.SetTrigger("hingeClosePARA");
                isDoorOpen = false;
            }
            else
            {
                Debug.Log("no door! or door is closed");

            }
        }



    }
}
