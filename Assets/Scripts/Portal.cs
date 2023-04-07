using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject Player;
    public GameObject DarkPortal;
    public GameObject HolyPortal;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("DarkPortal"))
        {
            Player.transform.position = DarkPortal.transform.position;
        }

        if (collision.gameObject.CompareTag("HolyPortal"))
        {
            Player.transform.position = HolyPortal.transform.position;
        }
    }
}
