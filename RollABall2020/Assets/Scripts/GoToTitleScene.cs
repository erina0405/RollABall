using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToTitleScene : MonoBehaviour
{
    public void ReturnTitleScene()
    {
        SceneManager.LoadScene("Title");
    }

   
}
