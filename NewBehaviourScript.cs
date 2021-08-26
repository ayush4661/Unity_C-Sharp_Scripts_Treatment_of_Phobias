using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public GameObject[] point;
	public float Speed;
	private int Cp;
	public float wp;
	Animator animator;
	GameObject tiger1;
	GameObject player;

	// Use this for initialization
	void Start () {
		tiger1 = GameObject.Find("tiger1");
		player = GameObject.Find("player");
		animator = gameObject.GetComponent<Animator>();
		animator.SetBool("IsRunning",false);
		animator.SetBool("IsAttacking",false);
		animator.SetBool("IsIdle",true);
		animator.SetBool("IsSounding",false);

		
	}
	
	// Update is called once per frame
	void Update () {
		if (animator.GetBool("IsPlay") == true){
		animator.SetBool("IsRunning",true);
		animator.SetBool("IsAttacking",false);
		animator.SetBool("IsSounding",false);
		animator.SetBool("IsIdle",false);
		transform.position = Vector3.MoveTowards (transform.position, point [Cp] . transform.position,Speed *Time.deltaTime);
		if (tiger1.transform.position.y <= 0.9034){
			animator.SetBool("IsSounding",true);
			animator.SetBool("IsRunning",false);
			animator.SetBool("IsIdle",false);
			animator.SetBool("IsAttacking",true);
			}  
		}

	
	}

}
