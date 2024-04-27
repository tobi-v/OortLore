using UnityEngine;
using Util;

public class CelestialBody : MonoBehaviour
{
    [SerializeField]
    public double Mass_earths;
    [SerializeField]
    public double Radius_km;
    [SerializeField]
    public Vector3 InitialPosition;

    public double Mass => mass;
    private double mass;                        // Unit: Solar Masses
    private double radius;                      // Unit: AU

    private void Awake() {
        mass = Mass_earths / Constants.SolarMass_InEarths;
        transform.position = InitialPosition;

        radius = Radius_km / Constants.Au_InKm;
        transform.localScale *= (float)radius;
    }
}
