using UnityEngine;
using System.Collections;

public class EnemiesBlack01 : MonoBehaviour 
{
	[SerializeField]
	public GameObject enemyBlack;
	[SerializeField]
	public int life = 1;
	[SerializeField]
	public float creationEnemyRate = 5f;
	[SerializeField]
	public float timeNextCreationEnemy = 1f;

	private EntidadeEnemyBlack01 entEnemy = new EntidadeEnemyBlack01 ();
	private EnemySpawner enemySpawner = new EnemySpawner ();

	// Use this for initialization
	void Start () 
	{
		entEnemy.EnemyBlack = enemyBlack;
		entEnemy.ObjetoHierarchyEnemyBlack = gameObject;
		entEnemy.Life = life;

		//Utilizando a classe Spawner************************************************************************************************************
		entEnemy = enemySpawner.SpawnEnemy(entEnemy);
		transform.position = entEnemy.EnemyBlack.transform.position;
		//*************************************************************************************************************************************************

		Debug.Log (string.Concat ("Tempo inicial para criacao de inimigo: ", entEnemy.CreationEnemyRate.ToString ()));
	}
	
	// Update is called once per frame
	void Update () 
	{
		CriacaoInstanciaEnemyBlack (); 
	}

	private void CriacaoInstanciaEnemyBlack()
	{
		entEnemy = enemySpawner.CriacaoInstanciaEnemyBlack (entEnemy);
	}
}
