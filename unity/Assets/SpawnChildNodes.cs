using UnityEngine;
using System.Collections;

public class SpawnChildNodes : MonoBehaviour {

	public GameObject crystal;
	public GameObject mobOne;
	public GameObject mobTwo;

	private GameObject localCrystal;
	private GameObject localMobOne;
	private GameObject localMobTwo;

	private Vector3 parentPosistion;
	private Quaternion parentRotation;

	void Start()
	{
		parentRotation = transform.rotation;
		parentPosistion = transform.position;
	}
	
	void OnBecameVisible()
	{
			//Add a crystal
			localCrystal = Instantiate(crystal, parentPosistion, parentRotation) as GameObject;
			localCrystal.transform.parent = transform;
			CreateAll.dynamicSpawnCount++;
			
	}
	
	void OnBecameInvisible()
	{
		CreateAll.dynamicSpawnCount--;
		Destroy (localCrystal);

	}
}
