using UnityEngine;
using System.Collections;

public class MoveForwardBulletPlayerOne : MonoBehaviour 
{

	public EntidadeBullet Movimentar(EntidadeBullet entBullet)
	{
		EntidadeBullet retorno = entBullet;
		float eixoX = 0f;
		float eixoY = entBullet.VelocidadeMovimentoVertical;
		float eixoZ = 0f;
		Vector3 posicao = entBullet.Bullet.transform.position; //recupera a posição atual do objeto
		Vector3 velocidade = new Vector3 (eixoX, eixoY, eixoZ); //seta a velocidade e distancia que o objeto deve percorrer.
		posicao += velocidade; //soma a posicao atual mais a velocidade e distancia.
		retorno.Bullet.transform.position = posicao;
		return retorno;
	}
}
