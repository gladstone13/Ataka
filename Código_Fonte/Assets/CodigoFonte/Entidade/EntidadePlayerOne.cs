using UnityEngine;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Text;


public class EntidadePlayerOne 

{
	//Utilizado na classe PlayerOneShipMovimento
	public float VelocidadeMovimentoHorizontal 
	{
		get;
		set;
	}

	//Utilizado na Classe PlayerOneShipMovimento
	public float MovimentoHorizontal 
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

	//Utilizado na classe PlayerOneShipTiro
	public GameObject Bullet 
	{
		get;
		set;
	}

	//Utilizado na classe PlayerOneShipTiro
	public float FireDelay 
	{
		get;
		set;
	}

	//Utilizado na classe PlayerOneShipTiro
	public Vector3 BulletOffSet 
	{
		get;
		set;
	}

	//Utilizado na classe PlayerOneSpawner
	public int Life 
	{
		get;
		set;
	}

	//Utilizado na classe PlayerOneSpawner
	public GameObject PlayerOne 
	{
		get;
		set;
	}

	//Utilizado na classe PlayerOneSpawner
	public GameObject InstanciaPlayerOne 
	{
		get;
		set;
	}

	//Utilizado na classe PlayerOneSpawner
	public GameObject ObjetoHierarchyPlayerOne 
	{
		get;
		set;
	}

	//Utilizado na classe PlayerOneSpawner
	public float RespawnTimer 
	{
		get;
		set;
	}






}
