using UnityEngine;
using System.Collections;

public class ParticleController : MonoBehaviour {

    ParticleSystem particles;

    void Start() {
        particles = GetComponent<ParticleSystem>();
        particles.Emit(1000);
        Destroy(gameObject, 5000);
    }
}
