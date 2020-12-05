using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// ずっと、ターゲットを追いかける
public class Forever_Chase_NavMesh : MonoBehaviour
{
	public string targetObjectName;   // 目標オブジェクト名：Inspectorで指定

	GameObject targetObject;
	NavMeshAgent agent;

	void Start() // 最初に、NaviAgentを取得しておいて
	{
		agent = GetComponent<NavMeshAgent>();
		// 目標オブジェクトを見つけておく
		targetObject = GameObject.Find(targetObjectName);
	}

	void Update() // ずっと、移動先を指定し続ける
	{
		agent.destination = targetObject.transform.position;
	}
}
