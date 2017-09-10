using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	// スコアラベル
	public UnityEngine.UI.Text scoreLabel;

	public void Update() {
		// Itemタグの個数を取得
		int count = GameObject.FindGameObjectsWithTag ("Item").Length;
		scoreLabel.text = count.ToString ();
	}

}
