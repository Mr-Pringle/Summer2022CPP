using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public enum Pickups
    {
        Powerups,
        Life,
        Score

    }

    public Pickups currentPickup;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerController curPlayer = collision.gameObject.GetComponent<PlayerController>();

            switch (currentPickup)
            {
                case Pickups.Life:
                    break;
                case Pickups.Powerups:
                    break;
                case Pickups.Score:
                    break;
            }

            Destroy(gameObject);
        }


    }
}
