using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ずっと、追いかける
public class Forever_Chase : MonoBehaviour
{
	public string targetObjectName;   // 目標オブジェクト名
	public float speed = 1; // スピード：Inspectorで指定
	GameObject targetObject;

	void Start () // 最初に、目標オブジェクトを見つけておく
	{
		targetObject = GameObject.Find(targetObjectName);
	}

	private void FixedUpdate() // ずっと、目標オブジェクトの方向を調べて
	{
		Vector3 dir = (targetObject.transform.position - this.transform.position).normalized;
		// その方向へ指定した量で進む
		float vx = dir.x * speed;
		float vz = dir.z * speed;
		this.transform.Translate(vx / 50, 0,  vz / 50);
	}
}
