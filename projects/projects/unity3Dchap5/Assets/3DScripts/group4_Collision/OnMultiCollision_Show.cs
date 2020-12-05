using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突したら、表示する（複数対応版）
public class OnMultiCollision_Show : MonoBehaviour
{
	public string tagName; // タグ名：Inspectorで指定
	public string showObjectName;  // 表示オブジェクト名：Inspectorで指定
	GameObject showObject;

	float orgY = 0;
	float ofsetY = 10000; // この値をY方向に足すことで消す

	void Start() // 最初に、消す前に表示オブジェクトを覚えておく
	{
		showObject = GameObject.Find(showObjectName);

		// Y方向に大きく移動させて消す
		orgY = showObject.transform.position.y;
		if (orgY > 100)
		{
			orgY -= ofsetY;
		}
		Vector3 pos = showObject.transform.position;
		pos.y = orgY + ofsetY;
		showObject.transform.position = pos;
	}

	private void OnCollisionEnter(Collision collision) // 衝突したとき
	{
		// もし、衝突したものが目標のタグを持っていたら
		if (collision.gameObject.tag == tagName)
		{
			// Yの位置を元に戻して表示する
			Vector3 pos = showObject.transform.position;
			pos.y = orgY;
			showObject.transform.position = pos;
		}
	}
}
