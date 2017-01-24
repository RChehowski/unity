using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour {

	[Serializable]
	public struct NameForField
	{
		[SerializeField]
		public string Name;

		[SerializeField]
		public string Field;
	}

	[SerializeField]
	NameForField nameForField;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
