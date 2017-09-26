﻿using UnityEngine;

public class InitGame: MonoBehaviour {

	public string[] paths = new string[] { null, null };
	public GameObject gamesObjs;
	public GameObject btns;

	public void Init() {
		if (this.paths[0] != null && this.paths[1] != null) {
			Controller ctrl = this.gamesObjs.GetComponentInChildren<Controller>();
			ctrl.Init(this.paths[0], this.paths[1]);

			this.gamesObjs.SetActive(true);
			this.btns.SetActive(false);
		}
	}
}