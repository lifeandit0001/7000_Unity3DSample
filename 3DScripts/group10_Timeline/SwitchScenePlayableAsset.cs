using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[System.Serializable]
// タイムラインにアタッチするアセット
public class SwitchScenePlayableAsset : PlayableAsset
{
	public string sceneName = "";  // シーン名：Inspectorで指定

	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		// 呼び出すインスタンスを作って
		SwitchSceneCmd cmd = new SwitchSceneCmd();
		// 変数を受け渡して
		cmd.sceneName = sceneName;
		// ビヘイビアスクリプトとつなぐ
		return ScriptPlayable<SwitchSceneCmd>.Create (graph, cmd);
	}
}
