using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newitemgenerator : MonoBehaviour {
    private GameObject unitychan;
    public GameObject carPrefab;
    public GameObject coinPrefab;
    public GameObject conePrefab;
    public int goalPos = 120;
    private float posRange = 3.4f;
    public float unidifference;
    public int startPos = -160;
    public float uniz;

    // Use this for initialization
    void Start () {
        this.unitychan = GameObject.Find("unitychan");

        //どのアイテムを出すのかをランダムに設定
        int num = Random.Range(1, 11);
        if (num <= 2)
        {
            //コーンをx軸方向に一直線に生成
            for (float j = -1; j <= 1; j += 0.4f)
            {
                GameObject cone = Instantiate(conePrefab) as GameObject;
                cone.transform.position = new Vector3(4 * j, cone.transform.position.y, unitychan.transform.position.z+50);
                unidifference = cone.transform.position.z - unitychan.transform.position.z;
                uniz = unitychan.transform.position.z + unidifference;
            }

        }
        else
        {

            //レーンごとにアイテムを生成
            for (int j = -1; j <= 1; j++)
            {
                //アイテムの種類を決める
                int item = Random.Range(1, 11);
                //アイテムを置くZ座標のオフセットをランダムに設定
                int offsetZ = Random.Range(-5, 6);
                //60%コイン配置:30%車配置:10%何もなし
                if (1 <= item && item <= 6)
                {
                    //コインを生成
                    GameObject coin = Instantiate(coinPrefab) as GameObject;
                    coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, unitychan.transform.position.z+50 + offsetZ);
                    unidifference = coin.transform.position.z - unitychan.transform.position.z;

                    uniz = unitychan.transform.position.z + unidifference;
                }
                else if (7 <= item && item <= 9)
                {
                    //車を生成
                    GameObject car = Instantiate(carPrefab) as GameObject;
                    car.transform.position = new Vector3(posRange * j, car.transform.position.y, unitychan.transform.position.z + 50 + offsetZ);
                    unidifference = car.transform.position.z - unitychan.transform.position.z;
                    uniz = unitychan.transform.position.z + unidifference;

                }
            }
        }
    }


	
	// Update is called once per frame
	void Update () {
    if (unitychan.transform.position.z <= goalPos - 50)
    {
        if (unitychan.transform.position.z >= uniz) { 
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                //コーンをx軸方向に一直線に生成
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab) as GameObject;
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, unitychan.transform.position.z + 50);
                    unidifference = cone.transform.position.z - unitychan.transform.position.z;
                    uniz = unitychan.transform.position.z + unidifference;
                }

            }
            else
            {

                //レーンごとにアイテムを生成
                for (int j = -1; j <= 1; j++)
                {
                    //アイテムの種類を決める
                    int item = Random.Range(1, 11);
                    //アイテムを置くZ座標のオフセットをランダムに設定
                    int offsetZ = Random.Range(-5, 6);
                    //60%コイン配置:30%車配置:10%何もなし
                    if (1 <= item && item <= 6)
                    {
                        //コインを生成
                        GameObject coin = Instantiate(coinPrefab) as GameObject;
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, unitychan.transform.position.z + 50 + offsetZ);
                        unidifference = coin.transform.position.z - unitychan.transform.position.z;

                        uniz = unitychan.transform.position.z + unidifference;
                    }
                    else if (7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab) as GameObject;
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, unitychan.transform.position.z + 50 + offsetZ);
                        unidifference = car.transform.position.z - unitychan.transform.position.z;
                        uniz = unitychan.transform.position.z + unidifference;

            }
        }
    }
}

}
	}
}
