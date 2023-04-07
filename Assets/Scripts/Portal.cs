using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject Player;
    public GameObject WarpTo;
    public GameObject StartPortal;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("DarkPortal"))
        {
            Player.transform.position = WarpTo.transform.position;
        }

        if (collision.gameObject.CompareTag("HolyPortal"))
        {
            Player.transform.position = WarpTo.transform.position;
        }
    }
}
