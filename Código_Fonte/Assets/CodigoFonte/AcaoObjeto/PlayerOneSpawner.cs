using UnityEngine;
using System.Collections;

public class PlayerOneSpawner : MonoBehaviour 
{
	private float eixoX = 23f;
	private float eixoY = -8.5f;
	private float eixoZ = 0f;


	#region Metodos
	//Cria uma nova instancia do PlayerOneShip na posicao certa
	public EntidadePlayerOne SpawnPlayer(EntidadePlayerOne pEntPlayerOne)
	{
		EntidadePlayerOne retorno = new EntidadePlayerOne ();
		retorno = pEntPlayerOne;
		Vector3 posicao = pEntPlayerOne.ObjetoHierarchyPlayerOne.transform.position;
		posicao = new Vector3 (eixoX, eixoY, eixoZ); 
		pEntPlayerOne.ObjetoHierarchyPlayerOne.transform.position = posicao;
		retorno.InstanciaPlayerOne = (GameObject) Instantiate (pEntPlayerOne.PlayerOne, pEntPlayerOne.ObjetoHierarchyPlayerOne.transform.position, Quaternion.identity);
		return retorno;
	}

	#endregion
}
