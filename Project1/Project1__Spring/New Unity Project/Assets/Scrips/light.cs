using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour {
    float m_speed;
    public bool m_worldSpace;

    // Use this for initialization
    void Start()
    {
        m_speed = 200.0f;
        transform.Rotate(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (m_worldSpace)
            transform.Rotate(Vector3.up * m_speed * Time.deltaTime, Space.World);
        else
            transform.Rotate(Vector3.up * m_speed * Time.deltaTime, Space.Self);
    }
}
