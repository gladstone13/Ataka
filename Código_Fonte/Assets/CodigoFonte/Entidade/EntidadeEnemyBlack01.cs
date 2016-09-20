using UnityEngine;
using System.Collections;

public class EntidadeEnemyBlack01 : MonoBehaviour 
{

	//Utilizado na classe Spawner
	public GameObject EnemyBlack 
	{
		get;
		set;
	}

	//Utilizado na classe Spawner
	public GameObject InstanciaEnemyBlack 
	{
		get;
		set;
	}

	//Utilizado na classe Spawner
	public GameObject ObjetoHierarchyEnemyBlack 
	{
		get;
		set;
	}

	//Utilizado na classe Spawner
	public int Life 
	{
		get;
		set;
	}
		
	//Utilizado na classe Spawner
	public float RespawnTimer 
	{
		get;
		set;
	}

	//Utilizado na classe Spawner
	public float CreationEnemyRate 
	{
		get;
		set;
	}

	//Utilizado na classe Spawner
	public float TimeNextCreationEnemy 
	{
		get;
		set;
	}

	//Utilizado na classe DamageHandler
	public int Health 
	{
		get;
		set;
	}

	//Utilizado na classe DamageHandler
	public float PeriodoInvulneravel 
	{
		get;
		set;
	}

	//Utilizado na classe DamageHandler
	public int LayerCorreto 
	{
		get;
		set;
	}




}
