using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloudCollisio1 : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "Cloud")
        {
            
            SceneManager.LoadScene("Win 1");
        }
    }
}
