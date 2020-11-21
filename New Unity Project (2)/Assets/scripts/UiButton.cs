using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiButton : MonoBehaviour
{
    
    public void RetryButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
