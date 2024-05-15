using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModuleHP : MonoBehaviour
{
    private int hp = 10;
    public int maxHp;
    public Text text;
    public bool isRightClick = false;
    public bool isLeftClick = false;

    public int HP() { return hp; }

    private void Start()
    {
        try
        {
            text.enabled = false;
        }
        catch { }
    }

    private void Update()
    {
        /*if(text.enabled == true)
            text.text = hp + " hp";*/
    }

    public void MinusHP()
    {
        if(hp > 0)
            hp--;
        text.text = hp + " hp";
        Debug.Log(hp);
        if(hp == 0)
        {
            Destroy();
        }
    }

    public void PlusHP()
    {
        if(hp < maxHp)
            hp++;
        text.text = hp + " hp";
        Debug.Log(hp);
        if (hp == 1)
        {
            Rebuild();
        }
    }

    private void Destroy()
    {
        transform.GetComponent<MeshCollider>().enabled = false;
        transform.GetComponent<MeshRenderer>().enabled = false;
    }

    private void Rebuild()
    {
        transform.GetComponent<MeshCollider>().enabled = true;
        transform.GetComponent<MeshRenderer>().enabled = true;
    }
}
