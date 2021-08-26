using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  
public class SceneChanger: MonoBehaviour {  
    public void Scene1() {  
        SceneManager.LoadScene("Acro");  
    }  
    public void Scene2() {  
        SceneManager.LoadScene("Astra");  
    }  
    public void Scene3() {  
        SceneManager.LoadScene("Zoo");  
    } 
    public void Scene4() {  
        SceneManager.LoadScene("StartMenu");  
    }  
} 