﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoGameScene : MonoBehaviour
{
    
    public void StartGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
