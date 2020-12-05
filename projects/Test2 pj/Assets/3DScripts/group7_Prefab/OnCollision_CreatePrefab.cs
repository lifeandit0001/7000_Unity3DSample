using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突したら、そこにプレハブからゲームオブジェクトを作る
public class OnCollision_CreatePrefab : MonoBehaviour
{
	public string tagName;
	public GameObject newPrefab;    // プレハブ：Inspectorで指定

	private void OnCollisionEnter(Collision collision) // 衝突したとき
	{
		// もし、衝突したものが目標のタグを持っていたら
		if (collision.gameObject.tag == tagName)
		{
			// 衝突位置にプレハブからゲームオブジェクトを作る
			GameObject newGameObject = Instantiate(newPrefab) as GameObject;
			Vector3 pos = collision.contacts[0].point;
			newGameObject.transform.position = pos;
		}
	}
}
