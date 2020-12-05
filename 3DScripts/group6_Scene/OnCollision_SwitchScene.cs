using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;	// シーン切り替えに必要

// 衝突したら、シーンを切り換える
public class OnCollision_SwitchScene : MonoBehaviour
{
	public string tagName; // 目標タグ名：Inspectorで指定
	public string sceneName = "";  // シーン名：Inspectorで指定

	private void OnCollisionEnter(Collision collision) // 衝突したとき
	{
		// もし、衝突したものが目標のタグを持っていたら
		if (collision.gameObject.tag == tagName)
		{
			if (sceneName != "")  // シーン名があれば、切り換える
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
}
