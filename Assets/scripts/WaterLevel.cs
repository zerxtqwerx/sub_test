using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLevel : MonoBehaviour
{
    public float topLine;
    public float bottomLine;
    float speed;
    public Vector3 scaleRoom;

    public int IsFlooding = 0;
    public GameObject waterPrefab;

    GameObject water;
    
    void Start()
    {
        if(IsFlooding == 1)
            Flood(0.001f);
    }

    void Update()
    {
        if (IsFlooding == 1)
        {
            Up();
        }
        else if(IsFlooding == -1)
        {
            Down();
        }
        
        /*if(water.transform.position.y > -0.9f)
        {
            Reduse(0.0001f);
        }*/
    }

    void Up()
    {
        if (water.transform.position.y < topLine)
            water.transform.position = new Vector3(water.transform.position.x, water.transform.position.y + speed, water.transform.position.z);
    }

    void Down()
    {
        if (water.transform.position.y > bottomLine - speed)
        {
            water.transform.position = new Vector3(water.transform.position.x, water.transform.position.y - speed, water.transform.position.z);
        }

        else
        {
            water.transform.GetComponent<MeshRenderer>().enabled = false;
            Destroy(water);
            IsFlooding = 0;
        }
    }

    public void Flood(float speed_)
    {
        water = Instantiate(waterPrefab, gameObject.transform.position, gameObject.transform.rotation, gameObject.transform);
        water.transform.localScale = scaleRoom;
        water.transform.GetComponent<MeshRenderer>().enabled = true;
        speed = speed_;
        IsFlooding = 1;
    }

    public void Reduse(float speed_)
    {
        speed = speed_;
        IsFlooding = -1;
    }
}
