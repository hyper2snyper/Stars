using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai : MonoBehaviour
{
    protected Mob parent;

    public virtual void set_up(Mob new_parent)
    {
        parent = new_parent;
        GetComponent<Transform>().position = parent.GetComponent<Transform>().position;
    }
}
