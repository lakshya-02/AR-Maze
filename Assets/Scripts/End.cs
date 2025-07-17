using System.Collections;
using UnityEngine;

public class End : MonoBehaviour {

	public GameObject winPanel;
	public GameObject winEffect;
	public float effectTime=10;

	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
		StartCoroutine(Win());
	}

	IEnumerator Win()
    {
		gameObject.GetComponent<AudioSource>().Play();
		winPanel.SetActive(true);
		winEffect.SetActive(true);

		yield return new WaitForSeconds(effectTime);

		gameObject.GetComponent<AudioSource>().Stop();
		winPanel.SetActive(false);
		winEffect.SetActive(false);
    }
}
