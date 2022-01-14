using UnityEngine;

public class Npc : Collidable
{
    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player")
        {
            Debug.Log("TEST 2");
        }
    }
}
