using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [Header("Levels To Load")]
    public string Level1;

    public void NewGameDialogYes()
    {
        SceneManager.LoadScene("SC1");
    }

    public void ExitButton()
    {
        Application.Quit();
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
