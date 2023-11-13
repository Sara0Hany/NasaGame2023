using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverText : MonoBehaviour
{
    public GameObject boxText;

    public void Start()
    {
        boxText.SetActive(false);
    }

    public void OnMouseOver()
    {
        boxText.SetActive(true);
    }

    public void OnMouseExit()
    {
        boxText.SetActive(false );
    }

}
