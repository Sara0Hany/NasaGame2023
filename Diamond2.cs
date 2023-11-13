using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Diamond2 : MonoBehaviour
{
    private int Coin = 0;
    public Scoring score;
    
    private void OnTriggerEnter(Collider other)
    {
      
        if (other.transform.tag == "Coin")
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("GameOver 2");
        }
    }
}
