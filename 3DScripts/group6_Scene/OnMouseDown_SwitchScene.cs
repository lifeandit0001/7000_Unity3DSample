using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;	// シーン切り替えに必要

// タッチしたら、シーンを切り換える
public class OnMouseDown_SwitchScene : MonoBehaviour
{
	public string sceneName = "";  // シーン名：Inspectorで指定

	private void OnMouseDown() // タッチしたとき
	{
		if (sceneName != "") // シーン名があれば、切り換える
		{
			SceneManager.LoadScene (sceneName);
		} else
		{	// シーン名がなければ、次のシーンへ切り換える
			int nextIndex = SceneManager.GetActiveScene().buildIndex + 1;
			if (nextIndex < SceneManager.sceneCountInBuildSettings){
				SceneManager.LoadScene(nextIndex);
			} else 
			{	// 次のシーンがなければ、最初のシーンに切り換える
				SceneManager.LoadScene(0);
			}
		}
	}
}
