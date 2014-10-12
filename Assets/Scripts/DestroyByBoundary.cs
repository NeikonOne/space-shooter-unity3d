using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour {
	void OnTriggerExit (Collider other) {
		Debug.Log ("Hello");
		Destroy (other.gameObject);
	}
}
