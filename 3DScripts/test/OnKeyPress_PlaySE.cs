using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キーを押すと、SEが鳴る
public class OnKeyPress_PlaySE : MonoBehaviour
{
	public AudioClip se;		// 効果音
	public string pushKey = "a"; // 押すキー：Inspectorで指定

	bool pushFlag = false; // キーを押しっぱなしかどうか

	void Update ()
	{
		if (Input.GetKey(pushKey)) // もし、キーが押されて
		{
			if (pushFlag == false) // 押しっぱなしでなければ、効果音を鳴らす
			{
				pushFlag = true; // 押した状態に
				gameObject.GetComponent<AudioSource>().PlayOneShot(se);
			}
		} else
		{
			pushFlag = false; 		// 押した状態解除
		}

	}
}
