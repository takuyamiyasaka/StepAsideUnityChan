using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  unitychanproduction : MonoBehaviour
{
    private GameObject unitychan;
    public GameObject carPrefab;
    public GameObject coinPrefab;
    public GameObject conePrefab;
    public int goalPos = 120;
    private float posRange = 3.4f;
    public float unidifference;
    public int startPos = -160;
    


    // Use this for initialization
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");

        //どのアイテムを出すのかをランダムに設定
        int num = Random.Range(1, 11);
        if (num <= 2)
        {
            //コーンをx軸方向に一直線に生成
            for (float j = -1; j <= 1; j += 0.4f)
            {
                GameObject cone = Instantiate(conePrefab) as GameObject;
                cone.transform.position = new Vector3(4 * j, cone.transform.position.y, startPos);
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
                    coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, startPos + offsetZ);

                }
                else if (7 <= item && item <= 9)
                {
                    //車を生成
                    GameObject car = Instantiate(carPrefab) as GameObject;
                    car.transform.position = new Vector3(posRange * j, car.transform.position.y, startPos + offsetZ);

                }
            }
        }
    }










    // Update is called once per frame
    void Update()
    {
        unidifference = carPrefab.transform.position.z-unitychan.transform.position.z;
        unidifference = conePrefab.transform.position.z - unitychan.transform.position.z;
        unidifference = coinPrefab.transform.position.z - unitychan.transform.position.z;
       
        if (unitychan.transform.position.z < unidifference) 
        
        {
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                //コーンをx軸方向に一直線に生成
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab) as GameObject;
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, unitychan.transform.position.z+50);
                    unidifference = unitychan.transform.position.z - cone.transform.position.z;
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
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, unitychan.transform.position.z + offsetZ+50);
                        unidifference = unitychan.transform.position.z - coin.transform.position.z;
                    }
                    else if (7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab) as GameObject;
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, unitychan.transform.position.z + offsetZ+50);
                        unidifference = unitychan.transform.position.z - car.transform.position.z;


                    }
                }
            }

            //アイテム生成します
        }
    }
}
//別のクラス











