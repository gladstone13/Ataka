using UnityEngine;
using System.Collections;

public class PlayerOneShips : MonoBehaviour {

	[SerializeField]
	public GameObject playerOnePreFab;
	[SerializeField]
	public int life;

	private EntidadePlayerOne entPlayerOne = new EntidadePlayerOne();
	private PlayerOneSpawner playerOneSpawner = new PlayerOneSpawner();

	// Use this for initialization
	void Start () 
	{
		//Setando valores para entidade
		entPlayerOne.ObjetoHierarchyPlayerOne = gameObject; //Objeto PlayerOneShips de Hierarchy do Unity
		entPlayerOne.PlayerOne = playerOnePreFab; //Valor Setado No Unity
		entPlayerOne.Life = life; //Valor Setado No Unity
		entPlayerOne.RespawnTimer = 1f;

		//Utilizando a classe PlayerOneSpawner************************************************************************************************************
		playerOneSpawner = new PlayerOneSpawner();
		entPlayerOne = playerOneSpawner.SpawnPlayer (entPlayerOne); //Cria Instancia do Player ao iniciar o jogo e modifica valores Life e InstanciaPlayerOne
		transform.position = entPlayerOne.PlayerOne.transform.position;
		//*************************************************************************************************************************************************
	}
	
	// Update is called once per frame
	void Update () 
	{
		CriarInstanciaObjetoQuandoMorre (); //Verifica se o Player morreu e ainda há vidas. Se há vidas, cria outra instancia
	}

	//Mostra na tela o número de vidas e a mensagem de Game Over
	void OnGUI() 
	{
		if (entPlayerOne.Life > 0 && entPlayerOne.InstanciaPlayerOne != null) 	
		{
			GUI.Label (new Rect (0, 0, 100, 50), string.Concat ("Vidas: ", entPlayerOne.Life.ToString ()));
		} 
		else if(entPlayerOne.Life == 0)
		{
			GUI.Label (new Rect (0, 0, 100, 50), string.Concat ("Vidas: ", entPlayerOne.Life.ToString ()));
			GUI.Label (new Rect (Screen.width/2 - 50, Screen.height/2 - 25, 100, 50), string.Concat ("Game Over!"));
		}
	}


	//Verifica se o número de vidas é maior que zero e se o objeto foi destruído
	//Caso tenha sido destruído, é criado outra instancia do objeto.
	private void CriarInstanciaObjetoQuandoMorre()
	{
		if (entPlayerOne.InstanciaPlayerOne == null && entPlayerOne.Life > 0) 
		{
			entPlayerOne.RespawnTimer -= Time.deltaTime;
			if (entPlayerOne.RespawnTimer <= 0) 
			{
				entPlayerOne.Life--; //Depois que o objeto é destruído, retira uma vida
				if (entPlayerOne.Life > 0) //Verifica se a vida do objeto é maior do que zero, para criar outra instancia
				{
					entPlayerOne = playerOneSpawner.SpawnPlayer (entPlayerOne);
				}
			}

		}
	}
}
