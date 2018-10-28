using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carproduction : MonoBehaviour
{
    public GameObject carPrefab;
    public GameObject unitychan;
    private float posRange = 3.4f;
    public int goalPos=120;
    private float unidiffrence;
    public float diffrence;
    public float uniz;

    // Use this for initialization
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");
        for (int j = -1; j <= 1; j++)
        {
            int offsetZ = Random.Range(-5, 6);
            GameObject car = Instantiate(carPrefab) as GameObject;
            car.transform.position = new Vector3(posRange*j, car.transform.position.y, unitychan.transform.position.z+offsetZ + 50);
            unidiffrence = car.transform.position.z - unitychan.transform.position.z;

            uniz = unitychan.transform.position.z + unidiffrence;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (unitychan.transform.position.z <= goalPos - 50)
        {
            if (unitychan.transform.position.z >= uniz)
                {
            
                 for (int j = -1; j <= 1; j++)
            {
                    int item = Random.Range(1, 11);
                    int offsetZ = Random.Range(-8, 8);
                        if (7 <= item && item <= 9)
                        {
                            GameObject car = Instantiate(carPrefab) as GameObject;






                            car.transform.position = new Vector3(posRange * j,car. transform.position.y, offsetZ + unitychan.transform.position.z + 50);

                            unidiffrence = car.transform.position.z - unitychan.transform.position.z;
                            uniz = unidiffrence + unitychan.transform.position.z;
                        }
            }
            }
        }
        
        

       
            }
            
        

    
}

