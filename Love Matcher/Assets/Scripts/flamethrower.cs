using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flamethrower : MonoBehaviour
{
    public GameObject flame;
    public float flameSpeed;
    public float flamelifetime;
    bool ha;
    // Start is called before the first frame update
    void Start()
    {
        ha = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (ha == true)
        {
            StartCoroutine(flameon());
        }
    }

    public IEnumerator flameon()
    {
        GameObject f = Instantiate(flame, transform.position, transform.localRotation);
        f.GetComponent<Rigidbody2D>().velocity = transform.right * flameSpeed;
        Destroy(f, flamelifetime);
        ha = false;
        yield return new WaitForSeconds(.05f);
        ha = true;
    }
}
