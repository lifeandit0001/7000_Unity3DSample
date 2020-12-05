using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突したら、自分自身と相手を削除する
public class OnCollision_DestoryBoth : MonoBehaviour
{
	public string tagName; // タグ名：Inspectorで指定

	private void OnCollisionEnter(Collision collision) // 衝突したとき
	{
		// もし、衝突したものが目標のタグを持っていたら
		if (collision.gameObject.tag == tagName)
		{
			// 相手と自分を削除する
			Destroy(collision.gameObject);
			Destroy(this.gameObject);
		}
	}
}
