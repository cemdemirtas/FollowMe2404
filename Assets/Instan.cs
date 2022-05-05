using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instan : MonoBehaviour
{
    private int lastNumber;
    public GameObject cube1, cube2, cube3;
    float RandomPosXLeft, RandomPosXRight, RandomPosXCenter, RandomPosZ, RandomPosX, RandomPosXFLeft, RandomPosXFRight;
    List<float> Xvalues = new List<float>();
    private void Awake()
    {

        RandomPosXLeft = -9.2f;
        RandomPosXFLeft = -4.2f;
        RandomPosXRight = -0.2f;
        RandomPosXFRight = 1.3f;
        RandomPosXCenter = 4;
        Xvalues.Add(RandomPosXRight);
        Xvalues.Add(RandomPosXLeft);
        Xvalues.Add(RandomPosXCenter);
        Xvalues.Add(RandomPosXLeft);
        Xvalues.Add(RandomPosXFLeft);
    }
    void Update()
    {
        float GenarateZ = Random.RandomRange(3f, 300f);








        if (transform.childCount < 15)
        {

            int GetRandom(int min, int max)
            {
                int rand = Random.Range(0, 5);
                while (rand == lastNumber)
                    rand = Random.Range(0, 5);
                lastNumber = rand;
                return rand;
            }

            GameObject InstantiateFollower1 = (GameObject)Instantiate(cube1, new Vector3(Xvalues[GetRandom(0,5)], transform.position.y, GenarateZ), Quaternion.identity);
            InstantiateFollower1.transform.name = "c1DenemeClone" + Random.RandomRange(0, 150);
            InstantiateFollower1.transform.parent = transform;

            GameObject InstantiateFollower2 = (GameObject)Instantiate(cube2, new Vector3(Xvalues[GetRandom(0, 5)], transform.position.y, GenarateZ), Quaternion.identity);
            InstantiateFollower2.transform.name = "c2DenemeClone" + Random.RandomRange(0, 150);
            InstantiateFollower2.transform.parent = transform;


            GameObject InstantiateFollower3 = (GameObject)Instantiate(cube3, new Vector3(Xvalues[GetRandom(0, 5)], transform.position.y, GenarateZ), Quaternion.identity);
            InstantiateFollower3.transform.name = "c3DenemeClone" + Random.RandomRange(0, 150);
            InstantiateFollower3.transform.parent = transform;


        }



    }
    //InstantiateFollower.transform.SetParent(FollowersParent);





}


