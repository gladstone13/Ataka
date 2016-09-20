using UnityEngine;
using System.Collections;

public class EnemyFacesPlayerOne : MonoBehaviour {

	Transform playerOneShip;
	public float rotSpeed = 90f;
	
	// Update is called once per frame
	void Update () 
	{
		//VALIDACAO DA EXISTENCIA DA NAVE DO JOGO****************************************
		if (playerOneShip == null) 
		{
			//Achando o PlayerOneShip
			GameObject go = GameObject.Find("PlayerOneShip");

			//se o PlayerOneShip existir [se nao tiver morrido no jogo]
			if (go != null) 
			{
				playerOneShip = go.transform;
			}
		}

		//se mesmo assim, o playerOneShip for null; tentará criar no proximo frame.
		if (playerOneShip == null) 
		{	return;
		}
		//********************************************************************************

		//A PARTIR DAQUI, A CODIFICAÇÃO PARA NAVE INIMIGA*********************************
		Vector3 direcao = playerOneShip.position - transform.position; //calcula qual é a direcao do playerOneShip
		direcao.Normalize();

		float zAngle = Mathf.Atan2 (direcao.y, direcao.x) * Mathf.Rad2Deg - 90; //Calcula o eixo Z para onde a nave inimiga deverá virar.
		Quaternion desiredRot = Quaternion.Euler(0,0,zAngle); // Calcula a rotação da nave inimiga para girar em seu próprio eixo a partir do eixo Z calculado.
		transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, rotSpeed * Time.deltaTime); //executa o movimento da nave a partir das variaveis calculadas

	}
}
