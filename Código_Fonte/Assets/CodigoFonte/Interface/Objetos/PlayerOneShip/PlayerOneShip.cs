using UnityEngine;
using System.Collections;

public class PlayerOneShip : MonoBehaviour {

	[SerializeField]
	public int health;
	[SerializeField]
	public float velocidadeMovimentoHorizontal = 0.4f;
	[SerializeField]
	public float invulPeriod = 0.5f;
	[SerializeField]
	public GameObject bulletPrefab;
	[SerializeField]
	public float fireDelay = 0.25f;
	[SerializeField]
	public Vector3 bulletOffset = new Vector3 (0, 1.6f, 0);


	private EntidadePlayerOne entPlayerOne = new EntidadePlayerOne();
	private PlayerOneShipMovimento playerOneShipMovimento = new PlayerOneShipMovimento ();
	private PlayerOneDamageHandler damageHandler = new PlayerOneDamageHandler ();
	private PlayerOneShipTiro playerOneShipTiro = new PlayerOneShipTiro ();

	float cooldownTimer = 0f;



	// Use this for initialization
	void Start () 
	{
		//Setando valores para entidade
		entPlayerOne.PlayerOne = gameObject;
		entPlayerOne.Health = health; //Valor Setado No Unity
		entPlayerOne.VelocidadeMovimentoHorizontal = velocidadeMovimentoHorizontal; //Valor Setado No Unity
		entPlayerOne.PeriodoInvulneravel = invulPeriod; //Valor setado no Unity
		entPlayerOne.LayerCorreto = gameObject.layer;
		entPlayerOne.Bullet = bulletPrefab; //Valor setado no Unity
		entPlayerOne.FireDelay = fireDelay; //Valor setado no Unity
		entPlayerOne.BulletOffSet = bulletOffset; //Valor setado no Unity

	}

	// Update is called once per frame
	void Update () 
	{
		Movimentar ();
		GerenciarImpactoParaVulnerabilidade ();
		Atirar ();
	}

	void OnTriggerEnter2D()
	{
		ImpactoTrigger ();
		entPlayerOne.Health--;
	}

	//*********************************************************************************************************************


	private void Movimentar()
	{
		entPlayerOne.MovimentoHorizontal = Input.GetAxis ("Horizontal");
		entPlayerOne = playerOneShipMovimento.Movimentar (entPlayerOne);
		transform.position = entPlayerOne.PlayerOne.transform.position;
	}

	private void GerenciarImpactoParaVulnerabilidade()
	{
		entPlayerOne = damageHandler.GerenciarImpactoParaVulnerabilidade (entPlayerOne);
		if (entPlayerOne.PlayerOne != null)
			gameObject.layer = entPlayerOne.PlayerOne.layer; //seta o layer de acordo com a lógica de vulnerabilidade
	}

	private void ImpactoTrigger()
	{
		
		Debug.Log (string.Concat ("Energia: ", entPlayerOne.Health.ToString ()));
		if (entPlayerOne.Health == 0) 
		{
			entPlayerOne = damageHandler.ImpactoTrigger (entPlayerOne);
			if (entPlayerOne.PlayerOne == null) 
			{
				Destroy (gameObject);
				//entPlayerOne.Health = health;
			}	
			else
				gameObject.layer = entPlayerOne.PlayerOne.layer;	
		}
	}

	private void Atirar()
	{
		cooldownTimer -= Time.deltaTime;
		if (Input.GetButtonDown ("Fire1") && cooldownTimer <=0) 
		{
			cooldownTimer = fireDelay;
			playerOneShipTiro.TiroPlayerOne (entPlayerOne);
		}
	}
}
