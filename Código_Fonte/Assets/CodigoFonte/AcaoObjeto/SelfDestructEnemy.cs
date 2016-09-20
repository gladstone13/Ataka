using UnityEngine;
using System.Collections;

public class SelfDestructEnemy: MonoBehaviour {

	public float timer = 60f;
	
	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		if (timer <= 0) 
		{
			Destroy (gameObject);
		}
	}
}
