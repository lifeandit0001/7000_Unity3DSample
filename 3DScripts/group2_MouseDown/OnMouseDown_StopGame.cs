using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチしたら、ゲームをストップする
public class OnMouseDown_StopGame : MonoBehaviour
{

	void Start () // 最初に、時間を動かす
	{
		Time.timeScale = 1;
	}

	private void OnMouseDown() // タッチしたら、時間を止める
	{
		Time.timeScale = 0;
	}
}
