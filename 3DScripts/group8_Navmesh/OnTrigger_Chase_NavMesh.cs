using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// 近寄ったら、ずっと、ターゲットを追いかける
public class OnTrigger_Chase_NavMesh : MonoBehaviour
{
	public string targetObjectName;   // 目標オブジェクト名：Inspectorで指定

	GameObject targetObject;
	NavMeshAgent agent;

	void Start() // 最初に
	{
		// NavMeshAgentを取得しておいて
		agent = GetComponent<NavMeshAgent>();
		// 目標オブジェクトを見つけておく
		targetObject = GameObject.Find(targetObjectName);
	}

	private void OnTriggerStay(Collider collider) // 目標オブジェクトが近寄ったら
	{
		if (collider.gameObject.name == targetObjectName)
		{
			// NavMeshAgentに目的地を指示し続ける
			agent.destination = targetObject.transform.position;
		}
	}

}
