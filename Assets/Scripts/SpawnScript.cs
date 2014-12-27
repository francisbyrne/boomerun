using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject [] obj;
	public bool firstSpawn = false;
	public float spawnMin = 1f;
	public float spawnMax = 2f;

	void Start ()
	{
		if (firstSpawn) {
				Spawn ();
		} else {
				Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
		}
	}

	void Spawn ()
	{
		Instantiate (obj [Random.Range (0, obj.Length)], transform.position, Quaternion.identity);
		Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
	}
}
