using UnityEngine;
using System.Collections;

public class MoveForwardEnemy : MonoBehaviour {

	float velocidadeMovimentoVertical = 0.015f;
	
	// Update is called once per frame
	void Update () 
	{
		Movimentar ();
	}

	void Movimentar()
	{
		float eixoX = 0f;
		float eixoY = (velocidadeMovimentoVertical);
		float eixoZ = 0f;
		Vector3 posicao = transform.position; //recupera a posição atual do objeto
		Vector3 velocidade = new Vector3 (eixoX, -eixoY, eixoZ); //seta a velocidade e distancia que o objeto deve percorrer.
		posicao += velocidade; //soma a posicao atual mais a velocidade e distancia.
		transform.position = posicao;
	}
}
