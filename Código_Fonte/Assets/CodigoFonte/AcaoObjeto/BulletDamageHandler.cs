using UnityEngine;
using System.Collections;

public class BulletDamageHandler : MonoBehaviour 
{
	public EntidadeBullet GerenciarImpactoParaVulnerabilidade(EntidadeBullet entBullet)
	{
		EntidadeBullet retorno = entBullet;
		//***************************************************************************************************
		//Tratamento para que dois triggers ocorridos em menos de meio segundo nao tire duas vidas. [se levar dois tirou ao mesmo tempo nao tira duas vidas, e sim uma vida]
		retorno.PeriodoInvulneravel -= Time.deltaTime; //variavel recebe ela mesma menos o tempo do último frame.
		if (retorno.PeriodoInvulneravel <= 0) //Verifica se o tempo desde o último frame é menor que meio segundo. 
		{
			retorno.Bullet.layer = entBullet.LayerCorreto; //Volta a ser vulnerável
		}
		//**************************************************************************************************
		return retorno;
	}
		

	public EntidadeBullet ImpactoTrigger(EntidadeBullet entBullet)
	{
		EntidadeBullet retorno = entBullet;
		entBullet.Bullet.layer = 10; //setar o layer "Invulneravel" criado. O número 10 é a posicao do layer na matriz.
		Destroy (retorno.Bullet);
		return retorno;
	}

}
