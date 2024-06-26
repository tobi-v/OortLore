using System;
using System.Collections.Generic;
using UnityEngine;

public class GravitationalForceCalculator
{
    private readonly double G_SI = 6.6743015 * Math.Pow(10, -11);   // N * m^2 / kg^2
    private readonly double G = 4.3009 * Math.Pow(10, -3);          // pc * (km/s)^2 / M_0, M_0: Solar mass

    public Vector3 GetGravitationalForce(CelestialBody body, List<CelestialBody> otherBodies) {
        Vector3 force = new();
        Vector3 distance;
        double m_1 = body.Mass;

        foreach (CelestialBody otherBody in otherBodies) {
            distance = otherBody.transform.position - body.transform.position;

            force += distance.normalized * (float)(G * m_1 * otherBody.Mass / distance.sqrMagnitude);
        }

        return force;
    }
}
