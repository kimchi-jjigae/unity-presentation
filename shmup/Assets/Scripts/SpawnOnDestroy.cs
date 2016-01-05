using UnityEngine;
using System.Collections;

public class SpawnOnDestroy : MonoBehaviour {

    public Transform particles;

    void OnDestroy() {
        Instantiate(particles, transform.position, transform.rotation);
    }
}
