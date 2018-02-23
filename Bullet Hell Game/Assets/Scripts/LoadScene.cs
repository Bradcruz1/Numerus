using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
	public void LoadLevel(int lvl)
	{
		SceneManager.LoadScene(lvl);
	}
}
