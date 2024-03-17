using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitationalBehaviour : MonoBehaviour {
    [SerializeField]
    private List<CelestialBody> celestialBodies;

    private readonly GravitationalForceCalculator GravitationalForceCalculator = new();
    private Vector3 force;

    void Update() {
        foreach (var body in celestialBodies) {
            force = GravitationalForceCalculator.GetGravitationalForce(body, celestialBodies);
        }
    }
}
