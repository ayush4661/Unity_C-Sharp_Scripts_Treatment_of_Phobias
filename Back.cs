﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Back : MonoBehaviour
{
    public void Scene() {  
        SceneManager.LoadScene("StartMenu");
    }
}
