using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour 
{
	private float eixoY = 7.5f;
	private float eixoZ = 0f;


	public EntidadeEnemyBlack01 CriacaoInstanciaEnemyBlack (EntidadeEnemyBlack01 entEnemy) 
	{
		EntidadeEnemyBlack01 retorno = entEnemy;
		retorno.TimeNextCreationEnemy -= Time.deltaTime;
		if (retorno.TimeNextCreationEnemy <= 0) 
		{
			retorno.TimeNextCreationEnemy = retorno.CreationEnemyRate;
			retorno = SpawnEnemy (retorno);
		}
		return retorno;
	}

	public EntidadeEnemyBlack01 SpawnEnemy(EntidadeEnemyBlack01 entEnemy)
	{
		EntidadeEnemyBlack01 retorno = entEnemy;

		Vector3 posicao = Random.onUnitSphere; //O eixo X fica ramdomico.
		posicao.y = eixoY;
		posicao.z = eixoZ;

		retorno.EnemyBlack.transform.position = posicao;
		retorno.InstanciaEnemyBlack = (GameObject) Instantiate (retorno.EnemyBlack, retorno.EnemyBlack.transform.position, Quaternion.identity);
		return retorno;
	}
}
