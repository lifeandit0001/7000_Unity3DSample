using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ときどき、範囲内にランダムにプレハブを作る
public class Sometime_RandomCreatePrefab : MonoBehaviour
{
	public GameObject newPrefab; // 作るプレハブ：Inspectorで指定
	public float intervalSec = 1; // 作成間隔（秒）：Inspectorで指定する

	void Start() // 最初に
	{
		// このオブジェクトのBoxColliderを解除
		this.GetComponent<BoxCollider>().enabled = false;
		// 指定秒ごとに、くり返し実行する予約をする
		InvokeRepeating("CreatePrefab", intervalSec, intervalSec);
		// コライダーを削除
		Collider col = this.gameObject.GetComponent<Collider>();
		if (col)
		{
			Destroy(col);
		}
	}

	void CreatePrefab()
	{
		// このオブジェクトの範囲内にランダムに
		Vector3 area = GetComponent<Renderer>().bounds.size;
		Vector3 newPos = this.transform.position;
		newPos.x += Random.Range(-area.x / 2, area.x / 2);
		newPos.y += Random.Range(-area.y / 2, area.y / 2);
		newPos.z += Random.Range(-area.z / 2, area.z / 2);
		// プレハブを作る
		GameObject newGameObject = Instantiate(newPrefab) as GameObject;
		newGameObject.transform.position = newPos;
	}
}
