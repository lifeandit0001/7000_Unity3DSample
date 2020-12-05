using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// クリックしたら、そこに向かって移動する
public class OnMouseDown_Move_NavMesh : MonoBehaviour
{
	NavMeshAgent agent;

	void Start() // 最初に
	{
		// NavMeshAgentを取得しておいて
		agent = GetComponent<NavMeshAgent>();
	}

	void Update()
	{
		if (Input.GetMouseButtonDown(0)) // もし、クリックしたら
		{
			RaycastHit hit;
			// 画面上のクリックした位置から3Dの奥へRayを飛ばしてぶつけて
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
			{
				// NavMeshAgentにその位置を指示する
				agent.destination = hit.point;
			}
		}
	}
}
