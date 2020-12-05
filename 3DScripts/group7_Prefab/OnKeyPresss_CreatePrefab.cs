using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キーを押したら、プレハブからゲームオブジェクトを作る
public class OnKeyPresss_CreatePrefab : MonoBehaviour 
{
	public GameObject newPrefab; // プレハブ：Inspectorで指定
	public string pushKey = "a"; // 押すキー：Inspectorで指定
	public float offsetX = 1;
	public float offsetY = 1;

	bool pushFlag = false;			// キーを押しっぱなしかどうか

	void Update() // ずっと、行う
	{
		if (Input.GetKey(pushKey)) // もし、キーが押されて
		{
			if (pushFlag == false) // 押しっぱなしでなければ
			{
				pushFlag = true; 		// 押した状態に
				Vector3 newPos = this.transform.position;
				// 少し上に表示
				newPos.x += offsetX;
				newPos.y += offsetY;
				newPos.y += 1;
				// プレハブからゲームオブジェクトを作る
				GameObject newGameObject = Instantiate(newPrefab) as GameObject;
				newGameObject.transform.position = newPos;
			}
		} else
		{
			pushFlag = false; 		// 押した状態解除
		}
	}

}
