using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[System.Serializable]
public class TestPlayableAsset : PlayableAsset
{
	public string msg = "Hello";	// インスペクタから受け取る変数
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		// 呼び出すインスタンスを作って
		TestCommand cmd = new TestCommand();
		// 変数を受け渡して
		cmd.msg = msg;
		// ビヘイビアスクリプトとつなぐ
		return ScriptPlayable<TestCommand>.Create (graph, cmd);
	}
}
