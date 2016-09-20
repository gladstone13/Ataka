using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour 
{
	[SerializeField]
	public int health = 1;
	[SerializeField]
	public float invulPeriod = 0f;
	[SerializeField]
	public float velocidadeMovimentoVertical = 0.25f;
	[SerializeField]
	public float timeToDead = 1f;


	private EntidadeBullet entBullet = new EntidadeBullet ();
	private BulletDamageHandler damageHandler = new BulletDamageHandler ();
	private MoveForwardBulletPlayerOne moveForward = new MoveForwardBulletPlayerOne();
	private SelfDestructBulletPlayerOne SelfDestruct = new SelfDestructBulletPlayerOne ();

	// Use this for initialization
	void Start () 
	{
		entBullet.Bullet = gameObject;
		entBullet.Health = health;
		entBullet.PeriodoInvulneravel = invulPeriod;
		entBullet.LayerCorreto = gameObject.layer;
		entBullet.VelocidadeMovimentoVertical = velocidadeMovimentoVertical;
		entBullet.TimeToDead = timeToDead;
	}

	void OnTriggerEnter2D()
	{
		entBullet.Health--;
		ImpactoTrigger ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		GerenciarImpactoParaVulnerabilidade ();
		Movimentar ();
		SelfDestructBullet ();
	}

	private void GerenciarImpactoParaVulnerabilidade()
	{
		entBullet = damageHandler.GerenciarImpactoParaVulnerabilidade (entBullet);
		if (entBullet.Bullet != null)
			gameObject.layer = entBullet.Bullet.layer;
	}

	private void ImpactoTrigger()
	{
		if (entBullet.Health <= 0) 
		{
			entBullet = damageHandler.ImpactoTrigger (entBullet);
			if (entBullet.Bullet == null)
				Destroy (gameObject);
		}

	}

	private void Movimentar()
	{
		entBullet = moveForward.Movimentar (entBullet);
		if (entBullet.Bullet != null)
			transform.position = entBullet.Bullet.transform.position;
	}

	private void SelfDestructBullet()
	{
		entBullet = SelfDestruct.SelfDestructBullet (entBullet);
		if (entBullet.Bullet == null)
			Destroy (gameObject);
	}
}
