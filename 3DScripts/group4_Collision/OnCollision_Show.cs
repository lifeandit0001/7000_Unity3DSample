using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突したら、表示する
public class OnCollision_Show : MonoBehaviour
{
	public string tagName; // タグ名：Inspectorで指定
	public string showObjectName;   // 表示するオブジェクト名：Inspectorで指定
	GameObject showObject;

	void Start() // 最初に、表示オブジェクトを覚えておいて
	{
		showObject = GameObject.Find(showObjectName);
		if (showObject) // 見つけたら
		{
			showObject.SetActive(false); // 消す
		}
	}

	private void OnCollisionEnter(Collision collision) // 衝突したとき
	{
		// もし、衝突したものが目標のタグを持っていたら
		if (collision.gameObject.tag == tagName)
		{
			showObject.SetActive(true); // 消していたものを表示する
		}
	}
}
