using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチしたら、そこにプレハブからゲームオブジェクトを作る
public class OnMouseDown_CreatePrefab : MonoBehaviour
{
	public GameObject newPrefab; // プレハブ：Inspectorで指定

	void Update() // ずっと、行う
	{
		if (Input.GetMouseButtonDown(0)) // もし、クリックしたら
		{
			RaycastHit hit;
			// 画面上のクリックした位置から3Dの奥へRayを飛ばしてぶつけて
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
			{
				// プレハブからゲームオブジェクトを作ってその位置に移動する
				GameObject newGameObject = Instantiate(newPrefab) as GameObject;
				newGameObject.transform.position = hit.point;
			}
		}
	}
}
