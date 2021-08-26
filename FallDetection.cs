using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetection : MonoBehaviour
{   
    GameObject player;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
	    player = GameObject.Find("player");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y <= 1.4)
        {   
            player.transform.position = new Vector3((float)467.8015, (float)11.67, (float)447.6237);
        }

    }
}
