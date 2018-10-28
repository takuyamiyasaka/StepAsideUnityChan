using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coneproducthon : MonoBehaviour {
    public GameObject unitychan;
    private float posRange = 3.4f;
    public int goalPos = 120;
    private float unidiffrence;
    public float diffrence;
    public float uniz;
    public GameObject conePrefab;

    // Use this for initialization


    // Use this for initialization
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");
        for (float j = -1; j <= 1; j += 0.4f)
        {
            GameObject cone = Instantiate(conePrefab) as GameObject;
            cone.transform.position = new Vector3(posRange*j, cone.transform.position.y, unitychan.transform.position.z + 50);
            unidiffrence = cone.transform.position.z - unitychan.transform.position.z;

            uniz = unitychan.transform.position.z + unidiffrence;
        }
    }


	
	// Update is called once per frame
	void Update ()
{
        if(unitychan.transform.position.z <= goalPos - 50)
        {
            if (unitychan.transform.position.z >= uniz)
            {

                int num = Random.Range(1, 11);
                if (num <= 2)
                {
                    //コーンをx軸方向に一直線に生成
                    for (float j = -1; j <= 1; j += 0.4f)
                    {
                        GameObject cone = Instantiate(conePrefab) as GameObject;
                        cone.transform.position = new Vector3(4 * j, cone.transform.position.y, unitychan.transform.position.z+50);
                    

                        unidiffrence = cone.transform.position.z - unitychan.transform.position.z;
                        uniz = unidiffrence + unitychan.transform.position.z;
                    }
                }
            }
        }




}
            
		
	}

