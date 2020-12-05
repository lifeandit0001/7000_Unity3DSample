using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突したら、ゲームをストップする
public class OnCollision_StopGame : MonoBehaviour
{
	public string tagName; // タグ名：Inspectorで指定

	void Start () // 最初に、時間を動かしておく
	{ 
		Time.timeScale = 1;
	}

	private void OnCollisionEnter(Collision collision) // 衝突したとき
	{ 
		// もし、衝突したものが目標のタグを持っていたら
		if (collision.gameObject.tag == tagName)
		{
			// 時間を止める
			Time.timeScale = 0;
		}
	}
}
