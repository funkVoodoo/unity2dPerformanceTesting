using UnityEngine;
using System.Collections;

public class CreateAll : MonoBehaviour {
	

	public static int dynamicSpawnCount;
	
	public GameObject[]	 injectObject = null; 
	public int	spawnCount = 10;
	public float speed = 200f;

	// Use this for initialization
	void Start () {
		
		float currentPos = 0f;
		dynamicSpawnCount = 0;
		
		if (injectObject != null) 
		{
			for (int a=0; a < spawnCount; a++)
			{
				//Chose a random posistion.
				int num = Random.Range(0, injectObject.Length);

				//Add to the world.. 
				Vector3 newPos = new Vector3(currentPos,0,0);
				Instantiate(injectObject[num], newPos, transform.rotation);
				
//				localObject = Instantiate(injectCrystalObject, mapObject.transform.position, mapObject.transform.rotation) as GameObject;
//				localObject.transform.parent = mapObject.transform;
								
				currentPos+=5.0f;
			}
		}
	}

	// Update is called once per frame
	void Update () {
		
		
		Vector3 tmp = new Vector3(speed *Time.deltaTime,0,0);
		transform.position += tmp;
		
		
	}


}
