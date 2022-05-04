using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instan : MonoBehaviour
{
    public GameObject cube1,cube2,cube3;
    float RandomPosXLeft, RandomPosXRight, RandomPosXCenter, RandomPosZ, RandomPosX, RandomPosXFLeft;
    List<float> Xvalues = new List<float>();
    private void Awake()
    {
       
        RandomPosXLeft = -8.5f;
        RandomPosXFLeft = -6f;
        RandomPosXRight = 2;
        RandomPosXCenter = 0;
        Xvalues.Add(RandomPosXRight);
        Xvalues.Add(RandomPosXLeft);
        Xvalues.Add(RandomPosXCenter);
        Xvalues.Add(RandomPosXFLeft);
    }
    void Update()
    {
        float GenarateZ= Random.RandomRange(3f, 300f);

        if (cube2.transform.position!=cube1.transform.position && cube1.transform.position!=cube2.transform.position)
        {
          
        
        if (transform.childCount<15)
        {
            GameObject InstantiateFollower = (GameObject)Instantiate(cube1, new Vector3(Xvalues[Random.RandomRange(0, 4)], transform.position.y, GenarateZ), Quaternion.identity);
            InstantiateFollower.transform.name = "c1DenemeClone" + Random.RandomRange(0, 150);
            InstantiateFollower.transform.parent = transform;
        }
        if (transform.childCount<15)
        {
            GameObject InstantiateFollower = (GameObject)Instantiate(cube2, new Vector3(Xvalues[Random.RandomRange(0, 4)], transform.position.y, GenarateZ), Quaternion.identity);
            InstantiateFollower.transform.name = "c2DenemeClone" + Random.RandomRange(0, 150);
            InstantiateFollower.transform.parent = transform;
        }
        if (transform.childCount<15)
        {
            GameObject InstantiateFollower = (GameObject)Instantiate(cube3, new Vector3(Xvalues[Random.RandomRange(0, 4)], transform.position.y, GenarateZ), Quaternion.identity);
            InstantiateFollower.transform.name = "c3DenemeClone" + Random.RandomRange(0, 150);
            InstantiateFollower.transform.parent = transform;
        }

        }
        //InstantiateFollower.transform.SetParent(FollowersParent);
        




        }
    }

