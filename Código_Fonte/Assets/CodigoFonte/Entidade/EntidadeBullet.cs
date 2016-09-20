using UnityEngine;
using System.Collections;

public class EntidadeBullet : MonoBehaviour 
{
	//Utilizado na classe DamageHandler
	public GameObject Bullet 
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

	//Utilizado na classe MoveForwardBulletPlayerOne
	public float VelocidadeMovimentoVertical 
	{
		get;
		set;
	}

	//Utilizado na classe PlayerOneTiro
	public float TimeToDead {
		get;
		set;
	}

}
