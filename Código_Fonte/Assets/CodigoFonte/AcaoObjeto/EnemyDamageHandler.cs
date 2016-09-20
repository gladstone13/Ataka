using UnityEngine;
using System.Collections;

public class EnemyDamageHandler : MonoBehaviour 
{
	public EntidadePlayerOne GerenciarImpactoParaVulnerabilidade(EntidadePlayerOne entPlayerOne)
	{
		EntidadePlayerOne retorno = entPlayerOne;
		//***************************************************************************************************
		//Tratamento para que dois triggers ocorridos em menos de meio segundo nao tire duas vidas. [se levar dois tirou ao mesmo tempo nao tira duas vidas, e sim uma vida]
		retorno.PeriodoInvulneravel -= Time.deltaTime; //variavel recebe ela mesma menos o tempo do último frame.
		if (retorno.PeriodoInvulneravel <= 0) //Verifica se o tempo desde o último frame é menor que meio segundo. 
		{
			retorno.PlayerOne.layer = entPlayerOne.LayerCorreto; //Volta a ser vulnerável
		}
		//**************************************************************************************************
		return retorno;
	}
		

	public EntidadePlayerOne ImpactoTrigger(EntidadePlayerOne entPlayerOne)
	{
		EntidadePlayerOne retorno = entPlayerOne;
		entPlayerOne.PlayerOne.layer = 10; //setar o layer "Invulneravel" criado. O número 10 é a posicao do layer na matriz.
		Destroy (retorno.PlayerOne);
		return retorno;

	}

}
