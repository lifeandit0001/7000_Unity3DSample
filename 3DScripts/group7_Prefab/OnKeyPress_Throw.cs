using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キーを押したら、ゲームオブジェクトを作って投げる
public class OnKeyPress_Throw : MonoBehaviour
{
	public GameObject newPrefab; // プレハブ：Inspectorで指定
	public string pushKey = "z"; // 押すキー：Inspectorで指定
	public float throwX = 0;     // 投げる力：Inspectorで指定
	public float throwY = 3;     // 投げる力：Inspectorで指定
	public float throwZ = 4;     // 投げる力：Inspectorで指定
	public float offsetX = 0f;   // 作る位置の高さオフセット：Inspectorで指定
	public float offsetY = 1f;   // 作る位置の高さオフセット：Inspectorで指定
	public float offsetZ = 0.5f; // 作る位置の高さオフセット：Inspectorで指定

	bool pushFlag = false;

	void Update() // ずっと、行う
	{
		if (Input.GetKey(pushKey)) // もし、キーが押されて
		{
			if (pushFlag == false) // 押しっぱなしでなければ
			{
				pushFlag = true; // 押した状態に
				Vector3 newPos = this.transform.position;
				Vector3 offset = new Vector3(offsetX, offsetY, offsetZ);
				offset = this.transform.rotation * offset;
				newPos = newPos + offset;

				// プレハブからゲームオブジェクトを作って
				GameObject newGameObject = Instantiate(newPrefab) as GameObject;
				newGameObject.transform.position = newPos;
				// 投げる
				Rigidbody rbody = newGameObject.GetComponent<Rigidbody>();
				Vector3 throwV = new Vector3(throwX, throwY, throwZ);
				throwV = this.transform.rotation * throwV;
				rbody.AddForce(throwV, ForceMode.Impulse);
			}
		} else
		{
			pushFlag = false; 		// 押した状態解除
		}
	}
}
