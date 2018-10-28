using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinproduction : MonoBehaviour {
    public GameObject unitychan;
    private float posRange = 3.4f;
    public int goalPos = 120;
    private float unidiffrence;
    public float diffrence;
    public float uniz;
    public GameObject coinPrefab;

    // Use this for initialization
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");
        for (int j = -1; j <= 1; j++)
        {
            int offsetZ = Random.Range(-5, 6);
            GameObject coin = Instantiate(coinPrefab) as GameObject;
            coin.transform.position = new Vector3(posRange*j, coin.transform.position.y, unitychan.transform.position.z+offsetZ + 50);
            unidiffrence = coin.transform.position.z - unitychan.transform.position.z;

            uniz = unitychan.transform.position.z + unidiffrence;

        }
    }
	
	// Update is called once per frame
	void Update () {
        if (unitychan.transform.position.z <= goalPos - 50)
        {
            if (unitychan.transform.position.z >= uniz)
            {
                for (int j = -1; j <= 1; j++)
        {
                    int item = Random.Range(1, 11);
                    int offsetZ = Random.Range(-7, 8);
                    if (1 <= item && item <= 6)
                    {
                        GameObject coin = Instantiate(coinPrefab) as GameObject;






                        coin.transform.position = new Vector3(posRange * j,coin.transform.position.y, offsetZ + unitychan.transform.position.z + 50);

                        unidiffrence = coin.transform.position.z - unitychan.transform.position.z;
                        uniz = unidiffrence + unitychan.transform.position.z;
                    }
                }
            }
}
        
        

       
            }
		
	}

