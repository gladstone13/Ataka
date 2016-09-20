using UnityEngine;
using System.Collections;

public class PlayerOneShipMovimento : MonoBehaviour 
{
	public EntidadePlayerOne Movimentar(EntidadePlayerOne entPlayerOne)
	{
		EntidadePlayerOne retorno = new EntidadePlayerOne ();
		retorno = entPlayerOne;
		float ShipBoundaryRadius = 1.5f;
		float eixoX = (entPlayerOne.MovimentoHorizontal * entPlayerOne.VelocidadeMovimentoHorizontal);
		float eixoY = 0f;
		float eixoZ = 0f;
		Vector3 posicao = entPlayerOne.PlayerOne.transform.position; //recupera a posição atual do objeto
		Vector3 velocidade = new Vector3 (eixoX, eixoY, eixoZ); //seta a velocidade e distancia que o objeto deve percorrer.
		posicao += velocidade; //soma a posicao atual mais a velocidade e distancia.
//
//
		//Limite no eixo X***********************************************************************************
		float screenRatio = (float)Screen.width / (float)Screen.height; //calcula o raio da tela
		float widthOrthographic = Camera.main.orthographicSize * screenRatio; //calcula o tamanho do eixo X multiplicando
																			  //o raio da tela pelo tamanho do eixo Y

		if (posicao.x > widthOrthographic - ShipBoundaryRadius) //verifica se a posicao do eixo X é maior do que o tamanho da tela (lado direito [positivo])
		{
			posicao.x = widthOrthographic - ShipBoundaryRadius;
		} 
		if (posicao.x < -widthOrthographic + ShipBoundaryRadius) //verifica se a posicao do eixo Y é maior do que o tamanho da tela (lado direito [positivo])
		{
			posicao.x = -widthOrthographic + ShipBoundaryRadius;
		} 
		//**************************************************************************************************

		//Movimenta o objeto
		retorno.PlayerOne.transform.position = posicao;
		return retorno;
	}

}
