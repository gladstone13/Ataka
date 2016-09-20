using UnityEngine;
using System.Collections;

public class EnemyShipTiro : MonoBehaviour 
{
	public GameObject bulletPrefab;
	public float fireDelay = 10f;
	public Vector3 bulletOffset = new Vector3 (0, -1.6f, 0);
	float cooldownTimer = 0f;

	// Update is called once per frame
	void Update () 
	{
		cooldownTimer -= Time.deltaTime;
		if (cooldownTimer <=0) 
		{
			cooldownTimer = fireDelay;

			Vector3 offSet = transform.rotation * bulletOffset; //objeto criado para indicar onde será criado o tiro a partir da nave

			//Instancia de objeto referenciado no Unity atraves da variável bulletPrefab
			//Essa instancia é criada a partir da mesma posicao da nave + valor passado pela bulletOffset.
			//A rotação transform.rotation está sendo multiplicada para caso a nave possa ser girada.
			Instantiate (bulletPrefab, transform.position + offSet, transform.rotation); 


		}
	
	}
}
