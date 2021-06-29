using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class eventmanagr : MonoBehaviour
{
    public void replaylvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void quitgn()
    {
        Application.Quit();
    }
   
}
