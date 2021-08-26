using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  
public class SceneChanger: MonoBehaviour {  
    public void Scene1() {  
        SceneManager.LoadScene("Acro"); //Switching to Acro scene.
    }  
    public void Scene2() {  
        SceneManager.LoadScene("Astra");  //Switching to Astra scene.
    }  
    public void Scene3() {  
        SceneManager.LoadScene("Zoo");  //Switching to Zoo scene.
    } 
    public void Scene4() {  
        SceneManager.LoadScene("StartMenu");  //Switching to StartMenu.
    }  
} 
