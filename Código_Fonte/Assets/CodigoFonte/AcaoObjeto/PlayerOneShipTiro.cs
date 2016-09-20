using UnityEngine;
using System.Collections;

public class PlayerOneShipTiro : MonoBehaviour 
{
	public void TiroPlayerOne(EntidadePlayerOne entPlayerOne)
	{
		Vector3 offSet = entPlayerOne.PlayerOne.transform.rotation * entPlayerOne.BulletOffSet; //objeto criado para indicar onde será criado o tiro a partir da nave

		//Instancia de objeto referenciado no Unity atraves da variável bulletPrefab
		//Essa instancia é criada a partir da mesma posicao da nave + valor passado pela bulletOffset.
		//A rotação transform.rotation está sendo multiplicada para caso a nave possa ser girada.
		Instantiate (entPlayerOne.Bullet, entPlayerOne.PlayerOne.transform.position + offSet, entPlayerOne.PlayerOne.transform.rotation); 
	}
}
