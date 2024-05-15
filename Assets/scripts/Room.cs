using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    private List<ModuleHP> walls;
    public WaterLevel wl;
    public string room_name;

    void Start()
    {
        GameObject[] gos = GameObject.FindGameObjectsWithTag(room_name);

        foreach (var g in gos)
        {
            try
            {
                walls.Add(g.GetComponent<ModuleHP>());
            }
            catch
            {

            }
        }
    }

    void Update()
    {
        bool hole = false;
        try
        {
            foreach (ModuleHP wall in walls)
            {
                if (wall.HP() == 0)
                {
                    hole = true;
                    break;
                }
            }
            if (hole)
            {
                wl.IsFlooding = 1;
            }
            else
            {
                wl.IsFlooding = 0;
            }
        }
        catch { }
    }
}
