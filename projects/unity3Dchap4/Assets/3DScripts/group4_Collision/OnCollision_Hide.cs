using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突したら、消す
public class OnCollision_Hide : MonoBehaviour
{
	public string tagName; // タグ名：Inspectorで指定
	public string hideObjectName;   // 消すオブジェクト名：Inspectorで指定

	private void OnCollisionEnter(Collision collision) // 衝突したとき
	{
		// もし、衝突したものが目標のタグを持っていたら
		if (collision.gameObject.tag == tagName)
		{
			// 消すオブジェクトを探して見つかったら
			GameObject hideObject = GameObject.Find(hideObjectName);
			if (hideObject)
			{
				hideObject.SetActive(false); // 消す
			}
		}
	}
}
