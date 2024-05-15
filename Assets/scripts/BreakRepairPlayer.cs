using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakRepairPlayer : MonoBehaviour
{
    //private Ray ray;
    //private RaycastHit hit;
    private GameObject gameObject;
    public Transform orientation;
    public LayerMask modules;

    private void Start()
    {
        //ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
        /*Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);*/
    }

    private void Update()
    {
        /*RaycastHit hit;
        if (Physics.Raycast(transform.position, orientation.position, out hit, Mathf.Infinity))
        {
            Debug.Log(hit.collider.gameObject.name);
        }*/

        RaycastHit hit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0)), out hit, Mathf.Infinity, modules))
        //if (Physics.Raycast(transform.position, Vector3.forward, out hit, 0.5f))
        {
            try
            {
                ModuleHP mhp = hit.transform.GetComponent<ModuleHP>();
                mhp.text.enabled = true;
                if (Input.GetMouseButtonDown(0))
                {
                    mhp.PlusHP();
                }
                if (Input.GetMouseButtonDown(1))
                {
                    mhp.MinusHP();
                }

            }
            catch { }
        }
    }
}
