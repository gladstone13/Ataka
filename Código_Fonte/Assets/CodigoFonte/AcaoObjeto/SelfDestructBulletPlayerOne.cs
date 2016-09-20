using UnityEngine;
using System.Collections;

public class SelfDestructBulletPlayerOne: MonoBehaviour 
{

	public EntidadeBullet SelfDestructBullet(EntidadeBullet entBullet)
	{
		EntidadeBullet retorno = entBullet;
		retorno.TimeToDead -= Time.deltaTime;
		if (retorno.TimeToDead <= 0) 
		{
			Destroy (retorno.Bullet);
		}
		return retorno;
	}
}
