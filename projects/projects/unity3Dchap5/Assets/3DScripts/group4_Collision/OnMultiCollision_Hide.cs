using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突したら、消す（複数対応版）
public class OnMultiCollision_Hide : MonoBehaviour
{
	public string tagName; // タグ名：Inspectorで指定
	public string hideObjecttName;  // 消すオブジェクト名：Inspectorで指定
	GameObject hideObject;

	float orgZ = 0;
	float ofsetZ = -10000; // この値をY方向に足すことで消す

	void Start() // 最初に、消すオブジェクトを覚えておく
	{
		hideObject = GameObject.Find(hideObjecttName);
		orgZ = hideObject.transform.position.z;
	}

	private void OnCollisionEnter(Collision collision) // 衝突したとき
	{
		// もし、衝突したものが目標のタグを持っていたら
		if (collision.gameObject.tag == tagName)
		{
			// Y方向に大きく移動させて消す
			Vector3 pos = hideObject.transform.position;
			pos.z = orgZ + ofsetZ;
			hideObject.transform.position = pos;
		}
	}
}
